using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortNumber
{
    public partial class fSub2 : Form
    {
        public fSub2()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;
            txt5.Text = null;

        }
    }
}
