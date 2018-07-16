using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldMining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btna1_Click(object sender, EventArgs e)
        {
            fSuba1 _dlg = new fSuba1();
            _dlg.ShowDialog();
        }

        private void btna2_Click(object sender, EventArgs e)
        {
            fSuba2 _dlg = new fSuba2();
            _dlg.ShowDialog();

        }

        private void btna3_Click(object sender, EventArgs e)
        {
            fSuba3 _dlg = new fSuba3();
            _dlg.ShowDialog();

        }

        private void btnb1_Click(object sender, EventArgs e)
        {
            fSubb1 _dlg = new fSubb1();
            _dlg.ShowDialog();

        }

        private void btnb2_Click(object sender, EventArgs e)
        {
            fSubb2 _dlg = new fSubb2();
            _dlg.ShowDialog();

        }

        private void btnb3_Click(object sender, EventArgs e)
        {
            fSubb3 _dlg = new fSubb3();
            _dlg.ShowDialog();

        }

        private void btnb4_Click(object sender, EventArgs e)
        {
            fSubb4 _dlg = new fSubb4();
            _dlg.ShowDialog();

        }
    }
}
