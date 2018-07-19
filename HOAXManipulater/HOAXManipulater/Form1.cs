using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAXManipulater
{
    public partial class Form1 : Form
    {
        private int mnMode;

        private void fShowSub()
        {
            switch (mnMode)
            {
                case 1:
                    fSub1 _dlg1 = new fSub1();
                    _dlg1.ShowDialog();
                    break;
                case 2:
                    fSub2 _dlg2 = new fSub2();
                    _dlg2.ShowDialog();
                    break;
                case 3:
                    fSub3 _dlg3 = new fSub3();
                    _dlg3.ShowDialog();
                    break;
                default:
                    fSub4 _dlg4 = new fSub4();
                    _dlg4.ShowDialog();
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            mnMode = 1;
            fShowSub();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            mnMode = 2;
            fShowSub();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            mnMode = 3;
            fShowSub();

        }

        private void btnOpen4_Click(object sender, EventArgs e)
        {
            mnMode = 4;
            fShowSub();

        }

        private void btnOpenR_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            mnMode = rnd1.Next(1, 5);
            fShowSub();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
