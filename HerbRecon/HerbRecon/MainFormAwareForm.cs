using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Closed += (o, e) =>
            {
                mf.Close();
            };
        }
    }
}
