using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerbLib;

namespace HerbRecon
{
    public partial class TestForm : Form
    {
        private MenuForm _mf;
        private TestingSession TestingSession { get; }
        private readonly Color _myDefaultBackColor;
        /// <summary>
        ///     Defines if the form is in the state of showing the result and disclosure to the user
        /// </summary>
        private bool CheckingAnswer { get; set; } = false;
        public TestForm(MenuForm mf, TestingSession testingSession)
        {
            InitializeComponent();
            _myDefaultBackColor = this.BackColor;
            TestingSession = testingSession;
            if (!TestingSession.TestFamilies) combo_family.Enabled = false;
            TestingSession.Next();
            LoadCurrentHerb();
            _mf = mf;
            this.Closing += (o, e) => { _mf.Show(); };
        }
        private readonly Random _random = new Random();

        /// <summary>
        ///     Loads the herb <paramref name="h"/> to the UI and saves it as the <see cref="ActualHerb"/>
        /// </summary>
        /// <param name="h"></param>
        private void LoadCurrentHerb()
        {
            var h = TestingSession.CurrentTestingObject.Object;
            // choose a random image from the list
            var url = h.ImageUrls[_random.Next(h.ImageUrls.Count)];
            pic_herb.Image = ImageCache.GetImage(url).Result;
            txt_answer.Text = "";
            combo_family.Text = "";
            lab_wholeName.Text = "";
            lab_latinName.Text = "";
        }

        private void txt_answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter && !CheckingAnswer)
            {
                var guessed = TestingSession.GuessCurrent(txt_answer.Text, combo_family.Text);
                lab_wholeName.Text = TestingSession.CurrentTestingObject.Object.ToString();
                lab_latinName.Text = TestingSession.CurrentTestingObject.Object.LatinName;
                this.BackColor = guessed ? Color.Green : Color.Red;
                CheckingAnswer = true;
            }
            else if (CheckingAnswer) {
                this.BackColor = _myDefaultBackColor;
                var next = TestingSession.Next();
                if (next != null) {
                    LoadCurrentHerb();
                }
                else {
                    MessageBox.Show("Testování skončilo.");
                    this.Close();
                }
                CheckingAnswer = false;
            }
        }
    }
}
