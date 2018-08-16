using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROPY
{
    public partial class fSub1 : Form
    {
        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fS11 _dlg = new fS11();
            _dlg.ShowDialog();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fS12 _dlg = new fS12();
            _dlg.ShowDialog();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fS13 _dlg = new fS13();
            _dlg.ShowDialog();

        }
    }
}
