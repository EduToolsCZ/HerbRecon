using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerbRecon
{
    public partial class SettingsFrom : Form
    {
        private readonly Settings _settings = Settings.Load();

        public SettingsFrom()
        {
            InitializeComponent();
        }

        private void SettingsFrom_Load(object sender, EventArgs e)
        {
            chck_updateHerbs.Checked = _settings.UpdateHerbList;
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            _settings.UpdateHerbList = chck_updateHerbs.Checked;
            _settings.Save();
            this.Close();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_issues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/StudentToolsGroup/HerbRecon/issues");
        }
    }
}
