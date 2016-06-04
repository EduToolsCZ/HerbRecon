using System;

namespace HerbRecon
{
    public partial class MenuForm : MainFormAwareForm
    {
        public MenuForm(MainForm mf) : base(mf)
        {
            InitializeComponent();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            MainForm.Close();
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            Hide();
            new TestStartForm(this).Show();
        }

        private void but_about_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog();
        }
    }
}