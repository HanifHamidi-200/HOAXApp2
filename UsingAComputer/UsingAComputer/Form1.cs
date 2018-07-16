using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingAComputer
{
    public partial class Form1 : Form
    {

        private List<String> _data1 = new List<string> { null, null, null, null };
        private List<String> _data2 = new List<string> { null, null, null, null };
        private List<String> _data3 = new List<string> { null, null, null, null };
        private int mnMode;

        private void fUpdateDisplay()
        {
            switch (mnMode)
            {
                case 1:
                    txtDescription.Text = _data1[0];
                    txtRating.Text = _data1[1];
                    txtMean.Text = _data1[2];
                    txtMode.Text = _data1[3];
                    break;
                case 2:
                    txtDescription.Text = _data2[0];
                    txtRating.Text = _data2[1];
                    txtMean.Text = _data2[2];
                    txtMode.Text = _data2[3];
                    break;
                default:
                    txtDescription.Text = _data3[0];
                    txtRating.Text = _data3[1];
                    txtMean.Text = _data3[2];
                    txtMode.Text = _data3[3];
                    break;
              }
        }

        private void fSave()
        {
            switch(mnMode){

                case 1:
                    _data1[0] = txtDescription.Text;
                    _data1[1] = txtRating.Text;
                    _data1[2] = txtMean.Text;
                    _data1[3] = txtMode.Text;
                    break;
                case 2:
                    _data2[0] = txtDescription.Text;
                    _data2[1] = txtRating.Text;
                    _data2[2] = txtMean.Text;
                    _data2[3] = txtMode.Text;
                    break;
                default:
                    _data3[0] = txtDescription.Text;
                    _data3[1] = txtRating.Text;
                    _data3[2] = txtMean.Text;
                    _data3[3] = txtMode.Text;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnMode = 1;
            fUpdateDisplay();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnMode = 1;
            fUpdateDisplay();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnMode = 2;
            fUpdateDisplay();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnMode = 3;
            fUpdateDisplay();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }
    }
}
