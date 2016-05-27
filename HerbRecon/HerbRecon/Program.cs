using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace HerbRecon
{
    static class Program
    {
        public const string UpdateUrl = @"http://sorashi.xf.cz/projects/herbrecon/releases";
        public static bool ShowTheWelcomeWizard = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
