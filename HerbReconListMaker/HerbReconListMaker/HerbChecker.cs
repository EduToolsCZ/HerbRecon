using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HerbLib;
using Newtonsoft.Json;

namespace HerbReconListMaker
{
    public partial class HerbChecker : Form
    {
        /// <summary>
        ///     The herb which is actually showing
        /// </summary>
        private Herb _actualHerb;

        private int _actualImageIndex = -1;
        private HerbCollection _newCollection = new HerbCollection();
        private HerbCollection _originalCollection = new HerbCollection();

        public HerbChecker()
        {
            InitializeComponent();
        }

        private void SaveActualHerb()
        {
            _actualHerb.Genus = txt_genus.Text;
            _actualHerb.Species = txt_species.Text;
            _actualHerb.Family = txt_family.Text;
            _actualHerb.LatinName = txt_latinName.Text;
        }

        private void LoadHerb(Herb h)
        {
            _actualHerb = h;
            txt_genus.Text = _actualHerb.Genus;
            txt_species.Text = _actualHerb.Species;
            txt_family.Text = _actualHerb.Family;
            txt_latinName.Text = _actualHerb.LatinName;
            txt_id.Text = _actualHerb.Id.ToString();
            if (_actualHerb.ImageUrls != null && _actualHerb.ImageUrls.Any())
            {
                _actualImageIndex = 0;
            }
            else
            {
                _actualImageIndex = -1;
            }
            RefreshImage();
        }

        private void RefreshImage()
        {
            if (_actualImageIndex >= 0)
            {
                var selectedUrl = _actualHerb.ImageUrls[_actualImageIndex];
                picture_herb.ImageLocation = selectedUrl;
                txt_imageUrl.Text = selectedUrl;
            }
            else
            {
                picture_herb.Image = null;
                txt_imageUrl.Text = "";
            }
        }

        private void RefreshComboBoxesItems()
        {
            combo_herb.Items.Clear();
            combo_missingHerbs.Items.Clear();
            combo_missingHerbs.SelectedIndex = -1;
            foreach (var herb in _newCollection.Herbs)
            {
                if (string.IsNullOrEmpty(herb.Family) || string.IsNullOrEmpty(herb.LatinName) || herb.ImageUrls == null ||
                    herb.ImageUrls.Count == 0)
                {
                    combo_missingHerbs.Items.Add(herb);
                    combo_missingHerbs.SelectedIndex = 0;
                }
                combo_herb.Items.Add(herb);
            }
            if (combo_herb.Items.Count == 0)
            {
                ShowError("No herbs were found.");
                Close();
            }
            combo_herb.SelectedIndex = 0;
        }

        /// <summary>
        ///     Shows an error as a dialog with the served <paramref name="message" />
        /// </summary>
        /// <param name="message"></param>
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveAndClose()
        {
            var fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                SelectedPath = Environment.CurrentDirectory,
                Description = "Select a folder"
            };
            if (fbd.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                return;
            }
            var directory = fbd.SelectedPath;
            var json = JsonConvert.SerializeObject(_newCollection, Formatting.None);
            File.WriteAllText(Path.Combine(directory, "Herbs.json"), json);
            json = JsonConvert.SerializeObject(_newCollection, Formatting.Indented);
            File.WriteAllText(Path.Combine(directory, "HerbsFormatted.json"), json);
            var md5 = Program.GetFileMd5(Path.Combine(directory, "Herbs.json"));
            File.WriteAllText(Path.Combine(directory, "md5.txt"), md5);
            if (check_openDirAfterClose.Checked)
            {
                Process.Start("explorer.exe", directory);
            }
            Close();
        }

        private void HerbChecker_Load(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Multiselect = false,
                CheckFileExists = true,
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "Json files|*.json|All files|*.*"
            };
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }
            _originalCollection = JsonConvert.DeserializeObject<HerbCollection>(File.ReadAllText(ofd.FileName));
            ReloadAll();
        }

        private void but_goToHerb_Click(object sender, EventArgs e)
        {
            LoadHerb(combo_herb.SelectedItem as Herb);
        }

        private void but_removeImage_Click(object sender, EventArgs e)
        {
            if (_actualHerb.ImageUrls.Count - 1 >= _actualImageIndex && _actualImageIndex >= 0)
            {
                _actualHerb.ImageUrls.RemoveAt(_actualImageIndex);
                _actualImageIndex = 0;
                RefreshImage();
            }
        }

        private void but_saveAndClose_Click(object sender, EventArgs e)
        {
            SaveAndClose();
        }

        private void but_reloadAll_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are you sure to reload all herbs? This will discard all of your changes.",
                "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ReloadAll();
            }
        }

        private void ReloadAll()
        {
            _newCollection = (HerbCollection) _originalCollection.Clone();
            if (_newCollection.Herbs.Count <= 0)
            {
                ShowError("No herbs were found.");
                Close();
                return;
            }
            LoadHerb(_newCollection.Herbs[0]);
            RefreshComboBoxesItems();
        }

        private void but_discardChanges_Click(object sender, EventArgs e)
        {
            LoadHerb(_actualHerb);
        }

        private void but_saveAndNext_Click(object sender, EventArgs e)
        {
            var index = _newCollection.Herbs.IndexOf(_actualHerb) + 1;
            SaveActualHerb();
            if (_newCollection.Herbs.Count - 1 >= index)
            {
                LoadHerb(_newCollection.Herbs[index]);
            }
            else
            {
                MessageBox.Show(
                    "You achieved the end of the herb file. Your herb has been saved. Press save and close to write everything to a file now.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void but_deleteHerb_Click(object sender, EventArgs e)
        {
            if (_newCollection.Herbs.Count <= 1)
            {
                ShowError("This is the last herb. You can't remove it");
                return;
            }
            _newCollection.Herbs.Remove(_actualHerb);
            RefreshComboBoxesItems();
            LoadHerb(_newCollection.Herbs[0]);
        }

        private void but_goToMissing_Click(object sender, EventArgs e)
        {
            LoadHerb((Herb) combo_missingHerbs.SelectedItem);
        }

        private void but_prevImage_Click(object sender, EventArgs e)
        {
            if (_actualHerb.ImageUrls.Count < 2) return;
            _actualImageIndex--;
            if (_actualImageIndex < 0)
            {
                _actualImageIndex = _actualHerb.ImageUrls.Count - 1;
            }
            RefreshImage();
        }

        private void but_nextImage_Click(object sender, EventArgs e)
        {
            if (_actualHerb.ImageUrls.Count < 2) return;
            _actualImageIndex++;
            if (_actualImageIndex > _actualHerb.ImageUrls.Count - 1)
            {
                _actualImageIndex = 0;
            }
            RefreshImage();
        }

        private void but_addImage_Click(object sender, EventArgs e)
        {
            _actualHerb.ImageUrls.Add(txt_imageUrl.Text);
            _actualImageIndex = 0;
            RefreshImage();
        }
    }
}