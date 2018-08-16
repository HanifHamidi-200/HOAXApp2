using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSTKK
{
    public partial class Form1 : Form
    {
        private List<int> _row1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _row2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _row3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<String> _rating = new List<string> { null, null, null };

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 12; i++)
            {
                _row1[i - 1] = rnd1.Next(1, 5);
                _row2[i - 1] = rnd1.Next(1, 5);
                _row3[i - 1] = rnd1.Next(1, 5);
            }

            for (int i = 1; i <= 3; i++)
            {
                _rating[i - 1] = null;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            txtRating1.Text = _rating[0];
            txtRating2.Text = _rating[1];
            txtRating3.Text = _rating[2];


            nRotate = 1;

            nType = _row1[0];
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = _row1[1];
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = _row1[2];
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = _row1[3];
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = _row1[4];
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = _row1[5];
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = _row1[6];
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = _row1[7];
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;
            nType = _row1[8];
            fPeek(nType, nRotate, ref _pic);
            pic19.Image = _pic.Image;
            nType = _row1[9];
            fPeek(nType, nRotate, ref _pic);
            pic1a.Image = _pic.Image;
            nType = _row1[10];
            fPeek(nType, nRotate, ref _pic);
            pic1b.Image = _pic.Image;
            nType = _row1[11];
            fPeek(nType, nRotate, ref _pic);
            pic1c.Image = _pic.Image;

            nType = _row2[0];
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = _row2[1];
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = _row2[2];
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = _row2[3];
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = _row2[4];
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = _row2[5];
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = _row2[6];
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = _row2[7];
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;
            nType = _row2[8];
            fPeek(nType, nRotate, ref _pic);
            pic29.Image = _pic.Image;
            nType = _row2[9];
            fPeek(nType, nRotate, ref _pic);
            pic2a.Image = _pic.Image;
            nType = _row2[10];
            fPeek(nType, nRotate, ref _pic);
            pic2b.Image = _pic.Image;
            nType = _row2[11];
            fPeek(nType, nRotate, ref _pic);
            pic2c.Image = _pic.Image;

            nType = _row3[0];
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = _row3[1];
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = _row3[2];
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = _row3[3];
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = _row3[4];
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = _row3[5];
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = _row3[6];
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = _row3[7];
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;
            nType = _row3[8];
            fPeek(nType, nRotate, ref _pic);
            pic39.Image = _pic.Image;
            nType = _row3[9];
            fPeek(nType, nRotate, ref _pic);
            pic3a.Image = _pic.Image;
            nType = _row3[10];
            fPeek(nType, nRotate, ref _pic);
            pic3b.Image = _pic.Image;
            nType = _row3[11];
            fPeek(nType, nRotate, ref _pic);
            pic3c.Image = _pic.Image;

        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F empty.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F green.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
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
                default:
                    _pic2 = picture5;
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
