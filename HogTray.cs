using System;
using HogmuraAudioTester.Resources;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace HogmuraAudioTester
{
    public class HogTray : ApplicationContext
    {
        public Form1 parent;

        private NotifyIcon trayIcon;
        private Thread backgroundThread;

        private bool threadInterrupt;
        private object monitor = new();

        public event EventHandler onOpenGUIRequested;
        public event EventHandler onCloseRequested;

        public HogTray(Form1 parent)
        {
            this.parent = parent;

            trayIcon = new NotifyIcon()
            {
                Icon = Hogs.hogmura_icon,
                ContextMenuStrip = new ContextMenuStrip(),
                Visible = true,
                Text = "Next hog in 00:00"
            };

            trayIcon.MouseUp += OnIconClick;

            var item = trayIcon.ContextMenuStrip.Items.Add("Quit");
            item.MouseUp += (s, e) => Close();

            item = trayIcon.ContextMenuStrip.Items.Add("Open GUI");
            item.MouseUp += OnOpenGUI;

            backgroundThread = new Thread(() =>
            {
                while (true)
                {
                    lock (monitor)
                    {
                        if (threadInterrupt)
                        {
                            break;
                        }

                        HogPlayer.PlayRandomSound();
                        var rnd = new Random(DateTime.Now.Millisecond);
                        int nextTime = rnd.Next(10000, 600000);
                        DateTime next = DateTime.Now.AddMilliseconds(nextTime);
                        string text = $"Next hog at {next:hh:mm:ss}";
                        trayIcon.Text = text;
                        Monitor.Wait(monitor, nextTime);

                        if (threadInterrupt)
                        {
                            break;
                        }
                    }
                }
            });
        }

        public void StartBackgroundHog()
        {
            threadInterrupt = false;
            backgroundThread.Start();
        }

        public void StopBackgroundHog()
        {
            lock (monitor)
            {
                threadInterrupt = true;
                Monitor.Pulse(monitor);
            }
        }

        private void OnIconClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HogPlayer.PlayRandomSound();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                Close();
            }
        }

        private void OnOpenGUI(object sender, MouseEventArgs e)
        {
            onOpenGUIRequested?.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
            ExitThread();
            trayIcon.Visible = false;
            onCloseRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}