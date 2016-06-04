using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerbRecon.Properties;

namespace HerbRecon
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            lab_version.Text = $"HerbRecon version {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void but_viewLicense_Click(object sender, EventArgs e)
        {
            try
            {
                const string licensePath = @"license.txt";
                File.WriteAllBytes(licensePath, Resources.LICENSE);
                Process.Start("notepad.exe", licensePath);
            }
            catch {
                try
                {
                    Process.Start(@"http://www.gnu.org/licenses");
                }
                catch (Exception ex)
                {
                    Extensions.ShowErrorMessageBox($"An error occured:\n{ex.Message}");
                }
            }
        }

        private void but_visitProject_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://www.github.com/StudentToolsGroup/HerbRecon");
        }
    }
}
