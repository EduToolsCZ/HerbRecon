using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerbLib;
using HerbRecon.Properties;

namespace HerbRecon
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            lab_version.Text =
                $"HerbRecon version {Assembly.GetExecutingAssembly().GetName().Version.GetSemanticVersion()}"
                + $" with HerbLib version {Assembly.GetAssembly(typeof (Herb)).GetName().Version.GetSemanticVersion()}";
        }

        private void but_viewLicense_Click(object sender, EventArgs e)
        {
            try {
                const string licensePath = @"license.txt";
                File.WriteAllBytes(licensePath, Resources.LICENSE);
                Process.Start("notepad.exe", licensePath);
            }
            catch {
                try {
                    Process.Start(@"http://www.gnu.org/licenses");
                }
                catch (Exception ex) {
                    Extensions.ShowErrorMessageBox($"An error occured:\n{ex.Message}");
                }
            }
        }

        private void but_visitProject_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://www.github.com/StudentToolsGroup/HerbRecon");
        }

        private void pic_easter_Click(object sender, EventArgs e)
        {
            using (var sp = new SoundPlayer(Resources.Get_out_frog))
            {
                sp.PlayLooping();
                MessageBox.Show("Get out!\n\nNeumožněte prokrastinaci, aby se Vás zmocnila! Vraťte se k testování!", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.None);
                sp.Stop();
            }
        }

        private void but_donate_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://sorashi.github.io/donate.html");
        }
    }
}
