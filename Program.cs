using System;
using System.Windows.Forms;

namespace HogmuraAudioTester
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            //Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}