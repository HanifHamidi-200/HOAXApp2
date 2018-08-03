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
    public partial class Form1 : Form
    {

        private int mnPortNumber;
        private int nNumber;

        private void fPortChange(int nOld,int nNew)
        {
            if (nNew == nOld)
            {
                return;
            }

            switch (nOld)
            {
                case 1:
                    btnPort1.BackColor = Color.Pink;
                    break;
                case 2:
                    btnPort2.BackColor = Color.Pink;
                    break;
                case 3:
                    btnPort3.BackColor = Color.Pink;
                    break;
                default:
                    btnPort4.BackColor = Color.Pink;
                    break;
            }
            switch (nNew)
            {
                case 1:
                    btnPort1.BackColor = Color.Red;
                    break;
                case 2:
                    btnPort2.BackColor = Color.Red;
                    break;
                case 3:
                    btnPort3.BackColor = Color.Red;
                    break;
                default:
                    btnPort4.BackColor = Color.Red;
                    break;
            }
            mnPortNumber = nNew;
        }

        private void fTwist()
        {
            Random rnd1 = new Random();
            nNumber = rnd1.Next(1, 10);

            mnPortNumber = 1;
            btnPort1.BackColor = Color.Red;

            if (nNumber <= 5)
            {
                pic1.Image = picMars.Image;
            }
            else
            {
                pic1.Image = picSpain.Image;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fTwist();
         }

        private void btnPort1_Click(object sender, EventArgs e)
        {
            fPortChange(mnPortNumber, 1);
        }

        private void btnPort2_Click(object sender, EventArgs e)
        {
            fPortChange(mnPortNumber, 2);
        }

        private void btnPort3_Click(object sender, EventArgs e)
        {
            fPortChange(mnPortNumber, 3);
        }

        private void btnPort4_Click(object sender, EventArgs e)
        {
            fPortChange(mnPortNumber, 4);
        }

             private void btnTwist_Click(object sender, EventArgs e)
        {
            fTwist();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }
    }
}
