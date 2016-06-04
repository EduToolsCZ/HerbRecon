using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerbRecon.Tools;
using Squirrel;

namespace HerbRecon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            SetStatus("Kontroluji aktuálnost aplikace");
            // controls the application update source
            using (var mgr = new UpdateManager(@"http://sorashi.xf.cz/projects/herbrecon/releases"))
            {
                await mgr.UpdateApp();
            }
            SetStatus("Aktualizuji informace o rostlinách");
            await HerbListManager.UpdateAsync();
            await Task.Delay(1200);
            SetStatus("Aktualizuji obrázky");
            await ImageCache.RefreshCache();
            SetStatus("Dokončuji");
            await Task.Delay(2000);
            Hide();
            new MenuForm(this).Show();
        }

        private void SetStatus(string status)
        {
            lab_status.Text = $"{status}...";
        }
    }
}