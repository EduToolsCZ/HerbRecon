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
            combo_family.Enabled = TestingSession.TestFamilies;
            combo_family.Items.AddRange(TestingSession.TestingObjects.Select(o => o.Object.Family).Distinct().ToArray());
            combo_family.Sorted = true;
            TestingSession.Next();
            LoadCurrentHerb();
            _mf = mf;
            this.Closing += (o, e) => { _mf.Show(); };
        }
        private readonly Random _random = new Random();

        /// <summary>
        ///     Loads the current herb from the <see cref="TestingSession"/> to the UI
        /// </summary>
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
                if (!CheckingAnswer) {
                    var guessed = TestingSession.GuessCurrent(txt_answer.Text, combo_family.Text);
                    lab_wholeName.Text = TestingSession.CurrentTestingObject.Object + ", " + TestingSession.CurrentTestingObject.Object.Family;
                    lab_latinName.Text = TestingSession.CurrentTestingObject.Object.LatinName;
                    this.BackColor = guessed ? Color.Green : Color.Red;
                    txt_answer.Enabled = combo_family.Enabled = false;
                    CheckingAnswer = true;
                }
                else {
                    this.BackColor = _myDefaultBackColor;
                    var next = TestingSession.Next();
                    if (next != null) {
                        LoadCurrentHerb();
                    }
                    else {
                        var message = "Testování skončilo.\n" +
                                      $"Celkový čas: {TestingSession.TestingTime:hh\\:mm\\:ss}\n" +
                                      $"Počet správných odpovědí: {TestingSession.TotalSuccesses}\n" +
                                      $"Počet špatných odpovědí: {TestingSession.TotalFails}\n" +
                                      $"Přesnost: {Math.Round((float)TestingSession.TotalSuccesses / (TestingSession.TotalSuccesses + TestingSession.TotalFails) * 100f, 2)} %";
                        MessageBox.Show(message);
                        this.Close();
                    }
                    txt_answer.Enabled = true;
                    txt_answer.Focus();
                    combo_family.Enabled = TestingSession.TestFamilies;
                    CheckingAnswer = false;
                }
            }
        }
    }
}
