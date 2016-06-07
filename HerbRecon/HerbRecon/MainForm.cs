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
            Settings settings;
            try
            {
                settings = Settings.Load();
            }
            catch (Exception ex)
            {
                Extensions.ShowErrorMessageBox($"Nepodařilo se načíst nastavení.\n{ex.GetDetailedMessage()}");
                settings = Settings.Default;
            }

            SetStatus("Kontroluji aktuálnost aplikace");
            // controls the application update source
            using (var mgr = new UpdateManager(@"http://sorashi.xf.cz/projects/herbrecon/releases"))
            {
                await mgr.UpdateApp();
            }

            if (settings.UpdateHerbList || !HerbListManager.FileExists())
            {
                SetStatus("Aktualizuji informace o rostlinách");
                await HerbListManager.UpdateAsync();
            }
            else
            {
                SetStatus("Načítám seznam rostlin");
                HerbListManager.LoadFromTheFile();
            }

            SetStatus("Aktualizuji obrázky (může chvíli trvat)");
            await ImageCache.RefreshCache();

            Hide();
            new MenuForm(this).Show();
        }

        private void SetStatus(string status)
        {
            lab_status.Text = $"{status}...";
        }
    }
}