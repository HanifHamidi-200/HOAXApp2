using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATOLD
{
    public partial class Form1 : Form
    {
        private List<int> _type = new List<int> { 0, 0, 0, 0 };
        private List<String> _sText = new List<string> { "ChemicalMakeup", "Communication", "Glue", "Gravity", "ChemicalMakeup", "Communication", "Glue", "Gravity", "ChemicalMakeup", "Communication", "Glue", "Gravity" };
        private String msAnalysis = null, msConclusion = null;

        private void fReset()
        {
            Random rnd1 = new Random();

            msAnalysis = null;
            msConclusion = null;

            for (int i = 1; i <= 4; i++)
            {
                _type[i - 1] = rnd1.Next(1, 13);
            }

            fUpdateDisplay();
        }
        private void fUpdateDisplay()
        {

            PictureBox _pic = new PictureBox();
            int nType, nRotate;
            String sText;

            txtAnalysis.Text = msAnalysis;
            txtConclusion.Text = msConclusion;

            nRotate =1;

            nType = _type[0];
            fPeek(nType, nRotate, ref _pic);
            pic1.Image = _pic.Image;
            nType = _type[1];
            fPeek(nType, nRotate, ref _pic);
            pic2.Image = _pic.Image;
            nType = _type[2];
            fPeek(nType, nRotate, ref _pic);
            pic3.Image = _pic.Image;
            nType = _type[3];
            fPeek(nType, nRotate, ref _pic);
            pic4.Image = _pic.Image;

            sText = _sText[_type[0]];
            lbl1.Text = sText;
            sText = _sText[_type[1]];
            lbl2.Text = sText;
            sText = _sText[_type[2]];
            lbl3.Text = sText;
            sText = _sText[_type[3]];
            lbl4.Text = sText;

        }
        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F bigChemicalMakeup.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F bigCommunication.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F bigGlue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F bigGravity.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F mediumChemicalMakeup.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F mediumCommunication.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F mediumGlue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F mediumGravity.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F smallChemicalMakeup.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F smallCommunication.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F smallGlue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F smallGravity.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
          
            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                case 12:
                    _pic2 = picture12;
                    break;
                default:
                    _pic2 = picture13;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
