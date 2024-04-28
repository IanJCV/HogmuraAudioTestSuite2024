using System;
using System.Windows.Forms;

namespace HogmuraAudioTester
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Start();
        }

        public static void Start()
        {
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            Application.Run(new Form1());
        }
    }
}