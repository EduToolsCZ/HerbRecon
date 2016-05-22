using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerbLib;

namespace HerbReconListMaker
{
    public partial class HerbChecker : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="herbs">The collection to check</param>
        public HerbChecker(HerbCollection herbs)
        {
            InitializeComponent();
        }
    }
}
