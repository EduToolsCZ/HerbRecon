using System;
using System.Windows.Forms;

namespace HerbRecon
{
    public class MainFormAwareForm : Form
    {
        [Obsolete("This is designer only method", true)]
        public MainFormAwareForm()
        {
        }

        public MainFormAwareForm(MainForm mf)
        {
            MainForm = mf;
            Closed += (o, e) => { MainForm.Close(); };
        }

        protected MainForm MainForm { get; set; }
    }
}