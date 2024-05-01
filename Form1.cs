using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;

namespace HogmuraAudioTester
{

    public partial class Form1 : Form
    {
        HogTray tray;

        private bool KeepOpenInTray;

        public Form1()
        {
            var prc = Process.GetProcessesByName(Application.ProductName);
            foreach (var item in prc)
            {
                item.Close();
            }

            InitializeComponent();
            tray = new HogTray(this);
            tray.onOpenGUIRequested += OnOpenRequested;
            tray.ThreadExit += (s, e) => HardExit();

            new Thread(() =>
            {
                Application.Run(tray);
            }).Start();
            this.FormClosing += OnClosing;
        }

        private void HardExit(bool alsoTerminateTray = false)
        {
            KeepOpenInTray = false;
            if (alsoTerminateTray)
            {
                tray?.Close();
            }
            Application.Exit();
            Process.GetCurrentProcess().Kill();
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            if (KeepOpenInTray)
            {
                e.Cancel = true;
                SetVisible(false);
            }
            else
            {
                tray?.Close();
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            HogPlayer.PlayStereo(1.0f, 0.0f);
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            HogPlayer.PlayStereo(1.0f, 1.0f);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            HogPlayer.PlayStereo(0.0f, 1.0f);
        }

        private void keepOpenInTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeepOpenInTray = keepOpenInTrayToolStripMenuItem.Checked;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HardExit(true);
        }

        private void playRandomHogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (playRandomHogsToolStripMenuItem.Checked)
            {
                tray?.StartBackgroundHog();
            }
            else
            {
                tray?.StopBackgroundHog();
            }
        }

        private void OnOpenRequested(object sender, EventArgs e)
        {
            SetVisible(true);
        }

        public void SetVisible(bool value)
        {
            if (value)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }
    }
}