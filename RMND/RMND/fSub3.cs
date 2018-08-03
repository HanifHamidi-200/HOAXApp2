using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMND
{
    public partial class fSub3 : Form
    {
        private int mnCastNumber;
        private List<int> _top = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _middle = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _bottom = new List<int> { 0, 0,0 };
        private List<int> _count = new List<int> { 0, 0, 0 };
        private List<String> _possibilities = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null ,null};

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F bottom.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F bottom_captured.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F middle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F middle_captured.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F taken.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F top.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F top_captured.png"),
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
                default:
                    _pic2 = picture7;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private int fCount(int nMode)
        {

            int nCount = 0;

            switch (nMode)
            {
                case 1:
                    for (int i = 1; i <= 7; i++)
                    {
                        if (_top[0] == 6)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 5; i++)
                    {
                        if (_middle[0] == 3)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                default:
                    for (int i = 1; i <= 3; i++)
                    {
                        if (_bottom[0] == 1)
                        {
                            nCount += 1;
                        }
                    }
                    break;
            }
            return nCount;
        }


        private void fUpdateDisplay2()
        {
            String sText = null;
            int nPos = 0;

            for(int i = 1; i <= 14; i++)
            {
                _possibilities[i - 1] = null;

            }
            for (int i = 1; i <= _count[0]; i++)
            {
                sText = "top" + Convert.ToString(i);
                nPos += 1;
                _possibilities[nPos - 1] = sText;
            }
            for (int i = 1; i <= _count[1] ; i++)
            {
                sText = "middle" + Convert.ToString(i);
                nPos += 1;
                _possibilities[nPos - 1] = sText;
            }
            for (int i = 1; i <= _count[2] ; i++)
            {
                sText = "bottom" + Convert.ToString(i);
                nPos += 1;
                _possibilities[nPos - 1] = sText;
            }

            lbl1.Text = _possibilities[0];
            lbl2.Text = _possibilities[1];
            lbl3.Text = _possibilities[2];
            lbl4.Text = _possibilities[3];
            lbl5.Text = _possibilities[4];
            lbl6.Text = _possibilities[5];
            lbl7.Text = _possibilities[6];
            lbl8.Text = _possibilities[7];
            lbl9.Text = _possibilities[8];
            lbla.Text = _possibilities[9];
            lblb.Text = _possibilities[10];
            lblc.Text = _possibilities[11];
            lbld.Text = _possibilities[12];
            lble.Text = _possibilities[13];
            lblf.Text = _possibilities[14];
        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            nRotate = 1;

            nType = _top[0];
            fPeek(nType, nRotate, ref _pic);
            picTop1.Image = _pic.Image;
            nType = _top[1];
            fPeek(nType, nRotate, ref _pic);
            picTop2.Image = _pic.Image;
            nType = _top[2];
            fPeek(nType, nRotate, ref _pic);
            picTop3.Image = _pic.Image;
            nType = _top[3];
            fPeek(nType, nRotate, ref _pic);
            picTop4.Image = _pic.Image;
            nType = _top[4];
            fPeek(nType, nRotate, ref _pic);
            picTop5.Image = _pic.Image;
            nType = _top[5];
            fPeek(nType, nRotate, ref _pic);
            picTop6.Image = _pic.Image;
            nType = _top[6];
            fPeek(nType, nRotate, ref _pic);
            picTop7.Image = _pic.Image;

            nType = _middle[0];
            fPeek(nType, nRotate, ref _pic);
            picMiddle1.Image = _pic.Image;
            nType = _middle[1];
            fPeek(nType, nRotate, ref _pic);
            picMiddle2.Image = _pic.Image;
            nType = _middle[2];
            fPeek(nType, nRotate, ref _pic);
            picMiddle3.Image = _pic.Image;
            nType = _middle[3];
            fPeek(nType, nRotate, ref _pic);
            picMiddle4.Image = _pic.Image;
            nType = _middle[4];
            fPeek(nType, nRotate, ref _pic);
            picMiddle5.Image = _pic.Image;

            nType = _bottom[0];
            fPeek(nType, nRotate, ref _pic);
            picBottom1.Image = _pic.Image;
            nType = _bottom[1];
            fPeek(nType, nRotate, ref _pic);
            picBottom2.Image = _pic.Image;
            nType = _bottom[2];
            fPeek(nType, nRotate, ref _pic);
            picBottom3.Image = _pic.Image;
        }


        private void fReset()
        {
            mnCastNumber = 743;

            for (int i = 1; i <= 7; i++)
            {
                _top[i -1] = 6;
            }
            for (int i = 1; i <= 4; i++)
            {
                _middle[i -1] = 3;
            }
            _middle[4] = 5;
            for (int i = 1; i <= 3; i++)
            {
                _bottom[i -1] = 1;
            }

            fUpdateDisplay();


            for (int i = 1; i <= 3; i++)
            {
                _count[i - 1] = fCount(i);
            }
            fUpdateDisplay2();
        }

        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
