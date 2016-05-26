using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerbLib;
using Newtonsoft.Json;

namespace HerbReconListMaker
{
    public partial class HerbChecker : Form
    {
        HerbCollection _originalCollection = new HerbCollection();
        private HerbCollection _newCollection = new HerbCollection();
        public HerbChecker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The herb which is actually showing
        /// </summary>
        private Herb _actualHerb;
        private int _actualImageIndex = -1;

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
            if (_actualHerb.ImageUrls != null && _actualHerb.ImageUrls.Any()) {
                _actualImageIndex = 0;

            }
            else {
                _actualImageIndex = -1;
            }
            RefreshImage();
        }
        private void RefreshImage()
        {
            if (_actualImageIndex >= 0) {
                var selectedUrl = _actualHerb.ImageUrls[_actualImageIndex];
                picture_herb.ImageLocation = selectedUrl;
                txt_imageUrl.Text = selectedUrl;
            }
            else {
                picture_herb.Image = null;
                txt_imageUrl.Text = "";
            }
        }

        private void RefreshComboBoxItems()
        {
            combo_herb.Items.Clear();
            foreach (var herb in _newCollection.Herbs) {
                combo_herb.Items.Add(herb);
            }
            if (combo_herb.Items.Count == 0) {
                ShowError("No herbs were found.");
                Close();
            }
            combo_herb.SelectedIndex = 0;
        }

        /// <summary>
        /// Shows an error as a dialog with the served <paramref name="message"/>
        /// </summary>
        /// <param name="message"></param>
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveAndClose()
        {
            var sfd = new SaveFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory
            };
            while (sfd.ShowDialog() != DialogResult.OK) {
                // do it again /\
            }
            var json = JsonConvert.SerializeObject(_newCollection, Formatting.None);
            File.WriteAllText(sfd.FileName, json);
            json = JsonConvert.SerializeObject(_newCollection, Formatting.Indented);
            File.WriteAllText(sfd.FileName, json);
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
            if (ofd.ShowDialog() != DialogResult.OK) {
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
            if (_actualHerb.ImageUrls.Count - 1 >= _actualImageIndex && _actualImageIndex >= 0) {
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
            var dr = MessageBox.Show("Are you sure to reload all herbs? This will discard all of your changes.", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                ReloadAll();
            }
        }

        private void ReloadAll()
        {
            _newCollection = (HerbCollection)_originalCollection.Clone();
            if (_newCollection.Herbs.Count <= 0) {
                ShowError("No herbs were found.");
                Close();
                return;
            }
            LoadHerb(_newCollection.Herbs[0]);
            RefreshComboBoxItems();
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
                MessageBox.Show("You achieved the end of the herb file. Your herb has been saved. Press save and close to write everything to a file now.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            RefreshComboBoxItems();
            LoadHerb(_newCollection.Herbs[0]);
        }
    }
}
