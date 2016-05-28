﻿using System;
using System.Windows.Forms;
using HerbRecon.Tools;

namespace HerbRecon
{
    public partial class TestStartForm : Form
    {
        public TestStartForm(MenuForm mf)
        {
            InitializeComponent();
            Menu = mf;
            Closed += (o, e) => { Menu.Show(); };
        }

        private MenuForm Menu { get; }

        private void TestStartForm_Load(object sender, EventArgs e)
        {
            list_tested.Items.Clear();
            list_notTested.Items.Clear();
            foreach (var herb in HerbListManager.HerbDatabase.Herbs)
            {
                list_tested.Items.Add(herb);
            }
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            var selected = list_notTested.SelectedItem;
            if (selected == null) return;
            list_notTested.Items.Remove(selected);
            list_tested.Items.Add(selected);
            list_notTested.SelectedIndex = list_notTested.Items.Count > 0 ? 0 : -1;
        }

        private void but_remove_Click(object sender, EventArgs e)
        {
            var selected = list_tested.SelectedItem;
            if (selected == null) return;
            list_tested.Items.Remove(selected);
            list_notTested.Items.Add(selected);
            list_tested.SelectedIndex = list_tested.Items.Count > 0 ? 0 : -1;
        }

        private void but_moveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in list_notTested.Items)
            {
                list_tested.Items.Add(item);
            }
            list_notTested.Items.Clear();
        }

        private void but_removeAll_Click(object sender, EventArgs e)
        {
            foreach (var item in list_tested.Items)
            {
                list_notTested.Items.Add(item);
            }
            list_tested.Items.Clear();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            // TODO: start testing
        }
    }
}