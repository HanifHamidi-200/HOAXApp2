using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerSource
{
    public partial class Form1 : Form
    {
        private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _attach4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _attach5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _analogue = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0,0,0 ,0,0};
        private static List<int> _digital = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 ,0,0,0,0};
        private int nNumber;
        private int mnCol, mnRow;
        private int mnSlot;
        private int mnItem;
        private bool mbAttach,mbRead;


        private void fAnalogue(int nPos)
        {
            if (_analogue[nPos - 1] == 1)
            {
                _analogue[nPos - 1] = 3;
            }
            else
{
                _analogue[nPos - 1] = 1;
            }
            fUpdateDisplay2();
        }

        private void fDigital(int nPos)
        {
            if (_digital[nPos - 1] == 1)
            {
                _digital[nPos - 1] = 9;
            }
            else
            {
                _digital[nPos - 1] = 1;
            }
            fUpdateDisplay2();
        }

        private void fRead(int nCol,int nRow)
        {
            int nIndex=0;
            String sText;

            if (mbRead)
            {
                mbRead = false;
                switch (nCol)
                {
                    case 4:
                        nIndex = _attach4[nRow - 1];
                        if (nIndex == 7)
                        {
                            return;
                        }
                        break;
                    case 5:
                        nIndex = _attach5[nRow - 1];
                        if (nIndex == 7)
                        {
                            return;
                        }
                        break;
                }
                switch (nIndex)
                {
                    case 1:
                        sText = "ERROR#1 needs localDB";
                        break;
                    case 2:
                        sText = "ERROR#2 Prognosis needs emphasising";
                        break;
                    case 3:
                        sText = "ERROR#3 BuggingBorders needs resolving";
                        break;
                    case 4:
                        sText = "ERROR#4 CRUDSystem needs intention";
                        break;
                    case 5:
                        sText = "ERROR#5 Razor needs ModifiableApproach";
                        break;
                    case 6:
                        sText = "NO ERRORS!";
                        break;
                    default:
                        sText = null;
                        break;
                }
                MessageBox.Show(sText, "Read");
                return;
            }

            fAttach(mnCol,mnRow);
        }
        private void fAttach(int nCol,int nRow)
        {
            DialogResult sReply;

            switch (nCol)
            {
                case 4:
                    if (mbAttach)
                    {
                        mbAttach = false;
                        if (_col4[mnRow - 1] >= 10)
                        {
                            _attach4[mnRow - 1] = mnItem;
                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }

                    }
                    else
                    {
                        if (_col4[mnRow - 1] >= 10)
                        {
                            sReply = MessageBox.Show(this, "Override?", "AddNode", MessageBoxButtons.YesNo);
                            if (sReply == DialogResult.Yes)
                            {
                                _col4[mnRow - 1] = mnSlot;
                                fUpdateDisplay();
                            }
                        }
                        else
                        {
                            _col4[mnRow - 1] = mnSlot;
                            fUpdateDisplay();
                        }
                    }
                    break;
                default:
                    if (mbAttach)
                    {
                        mbAttach = false;
                        if (_col5[mnRow - 1] >= 10)
                        {
                            _attach5[mnRow - 1] = mnItem;
                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }

                    }
                    else
                    {
                        if (_col5[mnRow - 1] >= 10)
                        {
                            sReply = MessageBox.Show(this, "Override?", "AddNode", MessageBoxButtons.YesNo);
                            if (sReply == DialogResult.Yes)
                            {
                                _col5[mnRow - 1] = mnSlot;
                                fUpdateDisplay();
                            }
                        }
                        else
                        {
                            _col5[mnRow - 1] = mnSlot;
                            fUpdateDisplay();
                        }
                    }
                    break;
            }
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;

            mnSlot = 10;
            mnItem = 7;
            mbAttach = false;
            mbRead = false;

            mnCol = rnd1.Next(1, 9);
            mnRow = rnd1.Next(1, 9);
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

            for (int i = 1; i <= 12; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _analogue[i - 1] = 3;
                }
                else
                {
                    _analogue[i - 1] = 1;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _digital [i - 1] = 9;
                }
                else
                {
                    _digital[i - 1] = 1;
                }
            }

            for (int i = 1; i <= 8; i++)
            {
                _col1[i - 1] = 2;
                _col2[i - 1] = 2;
                _col3[i - 1] = 2;
                _col4[i - 1] = 4;
                _col5[i - 1] = 4;
                _col6[i - 1] = 2;
                _col7[i - 1] = 2;
                _col8[i - 1] = 2;
                _attach4[i - 1] = 10;
                _attach5[i - 1] = 10;
            }

            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    nCol = 1;
                    nRow = i;
                    nType = rnd1.Next(5, 9);
                    switch (nCol)
                    {
                        case 1:
                            _col1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col3[nRow - 1] = nType;
                            break;
                        case 4:
                            _col4[nRow - 1] = nType;
                            break;
                        case 5:
                            _col5[nRow - 1] = nType;
                            break;
                        case 6:
                            _col6[nRow - 1] = nType;
                            break;
                        case 7:
                            _col7[nRow - 1] = nType;
                            break;
                        case 8:
                            _col8[nRow - 1] = nType;
                            break;
                    }
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    nCol = 3;
                    nRow = i;
                    nType = rnd1.Next(5, 9);
                    switch (nCol)
                    {
                        case 1:
                            _col1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col3[nRow - 1] = nType;
                            break;
                        case 4:
                            _col4[nRow - 1] = nType;
                            break;
                        case 5:
                            _col5[nRow - 1] = nType;
                            break;
                        case 6:
                            _col6[nRow - 1] = nType;
                            break;
                        case 7:
                            _col7[nRow - 1] = nType;
                            break;
                        case 8:
                            _col8[nRow - 1] = nType;
                            break;
                    }
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    nCol = 6;
                    nRow = i;
                    nType = rnd1.Next(5, 9);
                    switch (nCol)
                    {
                        case 1:
                            _col1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col3[nRow - 1] = nType;
                            break;
                        case 4:
                            _col4[nRow - 1] = nType;
                            break;
                        case 5:
                            _col5[nRow - 1] = nType;
                            break;
                        case 6:
                            _col6[nRow - 1] = nType;
                            break;
                        case 7:
                            _col7[nRow - 1] = nType;
                            break;
                        case 8:
                            _col8[nRow - 1] = nType;
                            break;
                    }
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    nCol = 8;
                    nRow = i;
                    nType = rnd1.Next(5, 9);
                    switch (nCol)
                    {
                        case 1:
                            _col1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col3[nRow - 1] = nType;
                            break;
                        case 4:
                            _col4[nRow - 1] = nType;
                            break;
                        case 5:
                            _col5[nRow - 1] = nType;
                            break;
                        case 6:
                            _col6[nRow - 1] = nType;
                            break;
                        case 7:
                            _col7[nRow - 1] = nType;
                            break;
                        case 8:
                            _col8[nRow - 1] = nType;
                            break;
                    }
                }
            }
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F across.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F air.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F analogue_in.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F chip.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F colour1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F colour2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F colour3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F colour4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F digital_out.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F slot1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F slot2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F slot3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F slot4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F slot5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F slot6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
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
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                   default:
                    _pic2 = picture16;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fUpdateDisplay2()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            nRotate = 1;

            nType = _analogue[0];
            fPeek(nType, nRotate, ref _pic);
            picA1.Image = _pic.Image;
            nType = _analogue[1];
            fPeek(nType, nRotate, ref _pic);
            picA2.Image = _pic.Image;
            nType = _analogue[2];
            fPeek(nType, nRotate, ref _pic);
            picA3.Image = _pic.Image;
            nType = _analogue[3];
            fPeek(nType, nRotate, ref _pic);
            picA4.Image = _pic.Image;
            nType = _analogue[4];
            fPeek(nType, nRotate, ref _pic);
            picA5.Image = _pic.Image;
            nType = _analogue[5];
            fPeek(nType, nRotate, ref _pic);
            picA6.Image = _pic.Image;
            nType = _analogue[6];
            fPeek(nType, nRotate, ref _pic);
            picA7.Image = _pic.Image;
            nType = _analogue[7];
            fPeek(nType, nRotate, ref _pic);
            picA8.Image = _pic.Image;
            nType = _analogue[8];
            fPeek(nType, nRotate, ref _pic);
            picA9.Image = _pic.Image;
            nType = _analogue[9];
            fPeek(nType, nRotate, ref _pic);
            picAa.Image = _pic.Image;
            nType = _analogue[10];
            fPeek(nType, nRotate, ref _pic);
            picAb.Image = _pic.Image;
            nType = _analogue[11];
            fPeek(nType, nRotate, ref _pic);
            picAc.Image = _pic.Image;

            nType = _digital[0];
            fPeek(nType, nRotate, ref _pic);
            picD1.Image = _pic.Image;
            nType = _digital[1];
            fPeek(nType, nRotate, ref _pic);
            picD2.Image = _pic.Image;
            nType = _digital[2];
            fPeek(nType, nRotate, ref _pic);
            picD3.Image = _pic.Image;
            nType = _digital[3];
            fPeek(nType, nRotate, ref _pic);
            picD4.Image = _pic.Image;
            nType = _digital[4];
            fPeek(nType, nRotate, ref _pic);
            picD5.Image = _pic.Image;
            nType = _digital[5];
            fPeek(nType, nRotate, ref _pic);
            picD6.Image = _pic.Image;
            nType = _digital[6];
            fPeek(nType, nRotate, ref _pic);
            picD7.Image = _pic.Image;
            nType = _digital[7];
            fPeek(nType, nRotate, ref _pic);
            picD8.Image = _pic.Image;
            nType = _digital[8];
            fPeek(nType, nRotate, ref _pic);
            picD9.Image = _pic.Image;
            nType = _digital[9];
            fPeek(nType, nRotate, ref _pic);
            picDa.Image = _pic.Image;
            nType = _digital[10];
            fPeek(nType, nRotate, ref _pic);
            picDb.Image = _pic.Image;
            nType = _digital[11];
            fPeek(nType, nRotate, ref _pic);
            picDc.Image = _pic.Image;

        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            fUpdateDisplay2();

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nRotate = 1;
                    switch (i)
                    {
                        case 1:
                            nType = _col1[j - 1];
                            break;
                        case 2:
                            nType = _col2[j - 1];
                            break;
                        case 3:
                            nType = _col3[j - 1];
                            break;
                        case 4:
                            nType = _col4[j - 1];
                            break;
                        case 5:
                            nType = _col5[j - 1];
                            break;
                        case 6:
                            nType = _col6[j - 1];
                            break;
                        case 7:
                            nType = _col7[j - 1];
                            break;
                        default:
                            nType = _col8[j - 1];
                            break;
                    }
                    fPeek(nType, nRotate, ref _pic);
                    switch (i)
                    {
                        case 1:
                            switch (j)
                            {
                                case 1:
                                    pic11.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic12.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic13.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic14.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic15.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic16.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic17.Image = _pic.Image;
                                    break;
                                default:
                                    pic18.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 2:
                            switch (j)
                            {
                                case 1:
                                    pic21.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic22.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic23.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic24.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic25.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic26.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic27.Image = _pic.Image;
                                    break;
                                default:
                                    pic28.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 3:
                            switch (j)
                            {
                                case 1:
                                    pic31.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic32.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic33.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic34.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic35.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic36.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic37.Image = _pic.Image;
                                    break;
                                default:
                                    pic38.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 4:
                            switch (j)
                            {
                                case 1:
                                    pic41.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic42.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic43.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic44.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic45.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic46.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic47.Image = _pic.Image;
                                    break;
                                default:
                                    pic48.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 5:
                            switch (j)
                            {
                                case 1:
                                    pic51.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic52.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic53.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic54.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic55.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic56.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic57.Image = _pic.Image;
                                    break;
                                default:
                                    pic58.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 6:
                            switch (j)
                            {
                                case 1:
                                    pic61.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic62.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic63.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic64.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic65.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic66.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic67.Image = _pic.Image;
                                    break;
                                default:
                                    pic68.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 7:
                            switch (j)
                            {
                                case 1:
                                    pic71.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic72.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic73.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic74.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic75.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic76.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic77.Image = _pic.Image;
                                    break;
                                default:
                                    pic78.Image = _pic.Image;
                                    break;
                            }
                            break;
                        default:
                            switch (j)
                            {
                                case 1:
                                    pic81.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic82.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic83.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic84.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic85.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic86.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic87.Image = _pic.Image;
                                    break;
                                default:
                                    pic88.Image = _pic.Image;
                                    break;
                            }
                            break;
                    }
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            fReset();
            fUpdateDisplay();
         }

        private void pic11_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 1;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic12_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 2;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic13_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 3;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic14_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 4;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic15_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 5;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic16_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 6;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic17_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 7;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic18_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 8;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic21_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 1;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic22_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 2;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic23_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 3;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic24_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 4;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic25_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 5;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic26_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 6;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic27_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 7;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic28_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 8;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic31_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 1;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic32_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 2;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic33_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 3;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic34_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 4;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic35_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 5;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic36_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 6;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic37_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 7;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic38_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 8;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic41_Click(object sender, EventArgs e)
        {
             mnCol = 4;
            mnRow = 1;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

            fRead(mnCol, mnRow);
         }

        private void pic42_Click(object sender, EventArgs e)
        {
             mnCol = 4;
            mnRow = 2;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           }

        private void pic43_Click(object sender, EventArgs e)
        {
              mnCol = 4;
            mnRow = 3;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
        }

        private void pic44_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 4;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
        }
        private void pic45_Click(object sender, EventArgs e)
        {
              mnCol = 4;
            mnRow = 5;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
        }

        private void pic46_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 6;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
        }

        private void pic47_Click(object sender, EventArgs e)
        {
             mnCol = 4;
            mnRow = 7;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
          }

        private void pic48_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 8;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
        }

        private void pic51_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 1;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           
        }

        private void pic52_Click(object sender, EventArgs e)
        {
             mnCol = 5;
            mnRow = 2;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           
        }

        private void pic53_Click(object sender, EventArgs e)
        {
             mnCol = 5;
            mnRow = 3;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           
        }

        private void pic54_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 4;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           
        }

        private void pic55_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 5;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           
        }

        private void pic56_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 6;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           
        }

        private void pic57_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 7;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           
        }

        private void pic58_Click(object sender, EventArgs e)
        {
             mnCol = 5;
            mnRow = 8;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            fRead(mnCol, mnRow);
           
        }

        private void pic61_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 1;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic62_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 2;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic63_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 3;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic64_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 4;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic65_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 5;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic66_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 6;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic67_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 7;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic68_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 8;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic71_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 1;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic72_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 2;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic73_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 3;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic74_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 4;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic75_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 5;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic76_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 6;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic77_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 7;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic78_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 8;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic81_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 1;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic82_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 2;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic83_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 3;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic84_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 4;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic85_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 5;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic86_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 6;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic87_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 7;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void pic88_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 8;
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

        }

        private void picSlot1_Click(object sender, EventArgs e)
        {
            mnSlot = 10;
        }

        private void picSlot2_Click(object sender, EventArgs e)
        {
            mnSlot = 11;
        }

        private void picSlot3_Click(object sender, EventArgs e)
        {
            mnSlot = 12;
        }

        private void picSlot4_Click(object sender, EventArgs e)
        {
            mnSlot = 13;
        }

        private void picSlot5_Click(object sender, EventArgs e)
        {
            mnSlot = 14;
        }

        private void picSlot6_Click(object sender, EventArgs e)
        {
            mnSlot = 15;
        }

        private void lstAttach_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lstAttach.SelectedIndex + 1;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            mbRead = true;
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            fLookup _dlg = new fLookup();
            _dlg.ShowDialog();
        }

     
        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 8; i++)
            {
                _col4[i - 1] = 4;
                _col5[i - 1] = 4;
             }
            fUpdateDisplay();
        }

        private void picA1_Click(object sender, EventArgs e)
        {
            fAnalogue(1);
        }

        private void picA2_Click(object sender, EventArgs e)
        {
            fAnalogue(2);
        }

        private void picA3_Click(object sender, EventArgs e)
        {
            fAnalogue(3);
        }

        private void picA4_Click(object sender, EventArgs e)
        {
            fAnalogue(4);
        }

        private void picA5_Click(object sender, EventArgs e)
        {
            fAnalogue(5);
        }

        private void picA6_Click(object sender, EventArgs e)
        {
            fAnalogue(6);
        }

        private void picA7_Click(object sender, EventArgs e)
        {
            fAnalogue(7);
        }

        private void picA8_Click(object sender, EventArgs e)
        {
            fAnalogue(8);
        }

        private void picA9_Click(object sender, EventArgs e)
        {
            fAnalogue(9);
        }

        private void picAa_Click(object sender, EventArgs e)
        {
            fAnalogue(10);
        }

        private void picAb_Click(object sender, EventArgs e)
        {
            fAnalogue(11);
        }

        private void picAc_Click(object sender, EventArgs e)
        {
            fAnalogue(12);
        }

        private void picD1_Click(object sender, EventArgs e)
        {
            fDigital(1);
        }

        private void picD2_Click(object sender, EventArgs e)
        {
            fDigital(2);
        }

        private void picD3_Click(object sender, EventArgs e)
        {
            fDigital(3);
        }

        private void picD4_Click(object sender, EventArgs e)
        {
            fDigital(4);
        }

        private void picD5_Click(object sender, EventArgs e)
        {
            fDigital(5);
        }

        private void picD6_Click(object sender, EventArgs e)
        {
            fDigital(6);
        }

        private void picD7_Click(object sender, EventArgs e)
        {
            fDigital(7);
        }

        private void picD8_Click(object sender, EventArgs e)
        {
            fDigital(8);
        }

        private void picD9_Click(object sender, EventArgs e)
        {
            fDigital(9);
        }

        private void picDa_Click(object sender, EventArgs e)
        {
            fDigital(10);
        }

        private void picDb_Click(object sender, EventArgs e)
        {
            fDigital(11);
        }

        private void picDc_Click(object sender, EventArgs e)
        {
            fDigital(12);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            mbAttach = true;
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
        }
    }
}

