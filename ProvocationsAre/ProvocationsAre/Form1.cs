using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvocationsAre
{
    public partial class Form1 : Form
    {
        private int mnProgrammerEngineer,mnTechnician;
        private List<int> _assign = new List<int> { 0, 0, 0, 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();

            mnProgrammerEngineer = rnd1.Next(1, 100);
            mnTechnician = 100 - mnProgrammerEngineer;
            lblTechnician.Text = "Technician = " + Convert.ToString(mnTechnician) + "%";
            lblPE.Text = "ProgrammerEngineer = " + Convert.ToString(mnProgrammerEngineer) + "%";

            for (int i = 1; i <= 6; i++)
            {
                _assign[i - 1] = rnd1.Next(1, 7);
            }
        }

        private void fAlter(int nMode)
        {
            switch (nMode)
            {
                case 1:
                    mnProgrammerEngineer += 1;
                    break;
                case 2:
                    mnProgrammerEngineer += 2;
                    break;
                case 3:
                    mnProgrammerEngineer += 3;
                    break;
                case 4:
                    mnProgrammerEngineer -= 1;
                    break;
                case 5:
                    mnProgrammerEngineer -= 2;
                    break;
                default:
                    mnProgrammerEngineer -= 3;
                    break;
            }
            mnTechnician = 100 - mnProgrammerEngineer;
            lblTechnician.Text = "Technician = " + Convert.ToString(mnTechnician) + "%";
            lblPE.Text = "ProgrammerEngineer = " + Convert.ToString(mnProgrammerEngineer) + "%";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void picOwner1_Click(object sender, EventArgs e)
        {
            fAlter(_assign[0]);
        }

        private void picOwner2_Click(object sender, EventArgs e)
        {
            fAlter(_assign[1]);
        }

        private void picOwner3_Click(object sender, EventArgs e)
        {
            fAlter(_assign[2]);
        }

        private void picOwner4_Click(object sender, EventArgs e)
        {
            fAlter(_assign[3]);
        }

        private void picOwner5_Click(object sender, EventArgs e)
        {
            fAlter(_assign[4]);
        }

        private void picOwner6_Click(object sender, EventArgs e)
        {
            fAlter(_assign[5]);
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            if (mnProgrammerEngineer == 72)
            {
                MessageBox.Show("You win", "GameEnd");
                fReset();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
