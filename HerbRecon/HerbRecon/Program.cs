using System;
using System.Windows.Forms;

namespace HerbRecon
{
    internal static class Program
    {
        public const string UpdateUrl = @"http://sorashi.xf.cz/projects/herbrecon/releases";
        public static bool ShowTheWelcomeWizard = false;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}