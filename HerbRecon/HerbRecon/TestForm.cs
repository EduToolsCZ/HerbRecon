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
        private TestingSession TestingSession { get; set; }
        private Herb ActualHerb { get; set; }
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
            LoadHerb(TestingSession.Start());
            _mf = mf;
            this.Closing += (o, e) => { _mf.Show(); };
        }
        private readonly Random _random = new Random();

        /// <summary>
        ///     Loads the herb <paramref name="h"/> to the UI and saves it as the <see cref="ActualHerb"/>
        /// </summary>
        /// <param name="h"></param>
        private void LoadHerb(Herb h)
        {
            ActualHerb = h;
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
            if (e.KeyCode == Keys.Enter && !CheckingAnswer) {
                CheckAnswer();
            }
            else if (CheckingAnswer) {
                this.BackColor = _myDefaultBackColor;
                var next = TestingSession.Next();
                if (next != null) {
                    LoadHerb(next);
                }
                else {
                    MessageBox.Show("Testování skončilo.");
                    this.Close();
                }
                CheckingAnswer = false;
            }
        }

        private void CheckAnswer()
        {
            CheckingAnswer = true;
            var name = txt_answer.Text.ToLower().Trim().RemoveDiacritics();
            var family = combo_family.Text.ToLower().Trim().RemoveDiacritics();
            var target = TestingSession.TestSpecies ? ActualHerb.ToString().RemoveDiacritics() : ActualHerb.Genus.RemoveDiacritics();
            var targetFamily = ActualHerb.Family.RemoveDiacritics();
            if (LevenshteinDistance(name, target) <= 2) {
                if (TestingSession.TestFamilies && LevenshteinDistance(family, targetFamily) > 2) {
                    TestingSession.Failed();
                    this.BackColor = Color.Red;
                }
                else {
                    TestingSession.Guessed();
                    this.BackColor = Color.Green;
                }
            }
            else {
                TestingSession.Failed();
                this.BackColor = Color.Red;
            }
            lab_wholeName.Text = ActualHerb.ToString();
            lab_latinName.Text = ActualHerb.LatinName;
        }

        /// <summary>
        ///     Computes the distance between two strings.
        /// </summary>
        private static int LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0) {
                return m;
            }

            if (m == 0) {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++) {
            }

            for (int j = 0; j <= m; d[0, j] = j++) {
            }

            // Step 3
            for (int i = 1; i <= n; i++) {
                //Step 4
                for (int j = 1; j <= m; j++) {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }
}
