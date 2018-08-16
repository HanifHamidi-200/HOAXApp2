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
    public partial class fSub2 : Form
    {
        public fSub2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fS21 _dlg = new fS21();
            _dlg.ShowDialog();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fS22 _dlg = new fS22();
            _dlg.ShowDialog();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fS23 _dlg = new fS23();
            _dlg.ShowDialog();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fS24 _dlg = new fS24();
            _dlg.ShowDialog();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            fS25 _dlg = new fS25();
            _dlg.ShowDialog();

        }
    }
}
