using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightningStrike
{
    public partial class Form1 : Form
    {
        private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeSquare1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeSquare2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeSquare3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeSquare4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeSquare5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeSquare6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeSquare7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeSquare8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeRotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeRotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeRotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeRotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeRotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeRotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeRotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _ModeRotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnModeSquareRow;
        private int nNumber;
        private int mnCounterCol, mnCounterRow,mnCounterRotate;
        private bool mbTake;
        private int nScore;

        private void fTake(int nCol,int nRow)
        {
            int nType;

            if (nCol > 30)
            {
                nType = 1;
            }
            else
            {
                nType = fType(nCol, nRow);
            }

            if (mbTake)
            {
                mbTake = false;
            }
            else
            {
                return;
            }

            switch (nType)
            {
                case 4:
                case 5:
                    switch (nCol)
                    {
                        case 1:
                            _col1[nRow - 1] = 1;
                            break;
                        case 2:
                            _col2[nRow - 1] = 1;
                            break;
                        case 3:
                            _col3[nRow - 1] = 1;
                            break;
                        case 4:
                            _col4[nRow - 1] = 1;
                            break;
                        case 5:
                            _col5[nRow - 1] = 1;
                            break;
                        case 6:
                            _col6[nRow - 1] = 1;
                            break;
                        case 7:
                            _col7[nRow - 1] = 1;
                            break;
                        default:
                            _col8[nRow - 1] = 1;
                            break;
                    }
                    nScore += 10;
                    lblScore.Text = "Score = " + Convert.ToString(nScore);
                    break;
                default:
                    break;
            }
        }

        private int fRotate(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _rotate1[nRow - 1];
                    
                case 2:
                    return _rotate2[nRow - 1];
                    
                case 3:
                    return _rotate3[nRow - 1];
                    
                case 4:
                    return _rotate4[nRow - 1];
                    
                case 5:
                    return _rotate5[nRow - 1];
                    
                case 6:
                    return _rotate6[nRow - 1];
                    
                case 7:
                    return _rotate7[nRow - 1];
                    
                default:
                    return _rotate8[nRow - 1];
                    
            }

        }
        private int fType(int nCol, int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _col1[nRow - 1];

                case 2:
                    return _col2[nRow - 1];

                case 3:
                    return _col3[nRow - 1];

                case 4:
                    return _col4[nRow - 1];

                case 5:
                    return _col5[nRow - 1];

                case 6:
                    return _col6[nRow - 1];

                case 7:
                    return _col7[nRow - 1];

                default:
                    return _col8[nRow - 1];

            }

        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nCol, nRow;
            int nFruits = rnd1.Next(20, 41);

            mbTake = false;

            for (int i = 1; i <= 30; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col1[i - 1] = 1;
                }
                else
                {
                    _col1[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col2[i - 1] = 1;
                }
                else
                {
                    _col2[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col3[i - 1] = 1;
                }
                else
                {
                    _col3[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col4[i - 1] = 1;
                }
                else
                {
                    _col4[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col5[i - 1] = 1;
                }
                else
                {
                    _col5[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col6[i - 1] = 1;
                }
                else
                {
                    _col6[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col7[i - 1] = 1;
                }
                else
                {
                    _col7[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col8[i - 1] = 1;
                }
                else
                {
                    _col8[i - 1] = 2;
                }
                _rotate1[i - 1] = rnd1.Next(1, 5);
                _rotate2[i - 1] = rnd1.Next(1, 5);
                _rotate3[i - 1] = rnd1.Next(1, 5);
                _rotate4[i - 1] = rnd1.Next(1, 5);
                _rotate5[i - 1] = rnd1.Next(1, 5);
                _rotate6[i - 1] = rnd1.Next(1, 5);
                _rotate7[i - 1] = rnd1.Next(1, 5);
                _rotate8[i - 1] = rnd1.Next(1, 5);
            }

            int nRotate = 0;

            nCol = 0;
            nRow = 0;
            do
            {
                nRow += 1;
                if (nRow == 1)
                {
                    nCol = rnd1.Next(1, 9);
                    nRotate = fRotate(nCol, nRow);
                    fStick(nCol, nRow,6,nRotate) ;
                }
                else
                {
                    nNumber = rnd1.Next(1, 10);
                    switch (nCol)
                    {
                        case 1:
                            if (nNumber <= 4)
                            {

                            }
                            else
                            {
                                nCol = 2;
                                nNumber = rnd1.Next(1, 10);
                                if (nNumber <= 5)
                                {
                                    nRow += 1;
                                }
                            }
                            break;
                        case 8:
                            if (nNumber <= 4)
                            {

                            }
                            else
                            {
                                nCol = 7;
                                nNumber = rnd1.Next(1, 10);
                                if (nNumber <= 5)
                                {
                                    nRow += 1;
                                }
                            }
                            break;
                        default:
                            if (nNumber <= 3)
                            {
                                nCol -= 1;
                                nRow -= 1;
                            }
                            else
                            {
                                if (nNumber <= 6)
                                {
                                    nCol += 1;
                                    nRow -= 1;
                                }
                                else
                                {
                                   }
                            }
                            break;
                    }
                    if (nRow == 31)
                    {
                        
                    }
                    else
                    {
                        nRotate = fRotate(nCol, nRow);
                        fStick(nCol, nRow, 6,nRotate);
                    }
                }
            } while (nRow < 30);

            for (int i = 1; i <= nFruits; i++)
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 31);
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    nRotate = fRotate(nCol, nRow);
                    fStick(nCol, nRow, 4,nRotate);
                }
                else
                {
                    nRotate = fRotate(nCol, nRow);
                    fStick(nCol, nRow, 5,nRotate);
                }
            }
            mnCounterCol = rnd1.Next(1, 9);
            mnCounterRow = rnd1.Next(mnModeSquareRow-7, mnModeSquareRow+1);
            mnCounterRotate = rnd1.Next(1, 5);

            fCopy();
            fUpdateDisplay();

        }

        private void fCopy()
        {
            int  nRow, nType,nRotate;

            nRow = 0;
            for (int i = mnModeSquareRow; i >= mnModeSquareRow - 7; i--)
            {
                nRow += 1;
                //nCol = 1;
                if (i > 30)
                {
                    nType = 8;
                }
                else
                {
                    nType = _col1[i - 1];
                }
                _ModeSquare1[nRow - 1] = nType;
                //nCol = 2;
                if (i > 30)
                {
                    nType = 8;
                }
                else
                {
                    nType = _col2[i - 1];
                }
                _ModeSquare2[nRow - 1] = nType;
                //nCol = 3;
                if (i > 30)
                {
                    nType = 8;
                }
                else
                {
                    nType = _col3[i - 1];
                }
                _ModeSquare3[nRow - 1] = nType;
                //nCol = 4;
                if (i > 30)
                {
                    nType = 8;
                }
                else
                {
                    nType = _col4[i - 1];
                }
                _ModeSquare4[nRow - 1] = nType;
                //nCol = 5;
                if (i > 30)
                {
                    nType = 8;
                }
                else
                {
                    nType = _col5[i - 1];
                }
                _ModeSquare5[nRow - 1] = nType;
                //nCol = 6;
                if (i > 30)
                {
                    nType = 8;
                }
                else
                {
                    nType = _col6[i - 1];
                }
                _ModeSquare6[nRow - 1] = nType;
                //nCol = 7;
                if (i > 30)
                {
                    nType = 8;
                }
                else
                {
                    nType = _col7[i - 1];
                }
                _ModeSquare7[nRow - 1] = nType;
                //nCol = 8;
                if (i > 30)
                {
                    nType = 8;
                }
                else
                {
                    nType = _col8[i - 1];
                }
                _ModeSquare8[nRow - 1] = nType;
                //nCol = 1;
                if (i > 30)
                {
                    nRotate = 1;
                }
                else
                {
                    nRotate = _rotate1[i - 1];
                }
                _ModeRotate1[nRow - 1] = nRotate;
                //nCol = 2;
                if (i > 30)
                {
                    nRotate = 1;
                }
                else
                {
                    nRotate = _rotate2[i - 1];
                }
                _ModeRotate2[nRow - 1] = nRotate;
                //nCol = 3;
                if (i > 30)
                {
                    nRotate = 1;
                }
                else
                {
                    nRotate = _rotate3[i - 1];
                }
                _ModeRotate3[nRow - 1] = nRotate;
                //nCol = 4;
                if (i > 30)
                {
                    nRotate = 1;
                }
                else
                {
                    nRotate = _rotate4[i - 1];
                }
                _ModeRotate4[nRow - 1] = nRotate;
                //nCol = 5;
                if (i > 30)
                {
                    nRotate = 1;
                }
                else
                {
                    nRotate = _rotate5[i - 1];
                }
                _ModeRotate5[nRow - 1] = nRotate;
                //nCol = 6;
                if (i > 30)
                {
                    nRotate = 1;
                }
                else
                {
                    nRotate = _rotate6[i - 1];
                }
                _ModeRotate6[nRow - 1] = nRotate;
                //nCol = 7;
                if (i > 30)
                {
                    nRotate = 1;
                }
                else
                {
                    nRotate = _rotate7[i - 1];
                }
                _ModeRotate7[nRow - 1] = nRotate;
                //nCol = 8;
                if (i > 30)
                {
                    nRotate = 1;
                }
                else
                {
                    nRotate = _rotate8[i - 1];
                }
                _ModeRotate8[nRow - 1] = nRotate;
            }
        }

        private void fPeek(int nValue,int nRotate,ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F blank2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F fruits1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F fruits2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F road.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F YOU.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
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
                default:
                    _pic2 = picture8;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }
        private void fUpdateDisplay()
        {
            int nCol, nRow;

            nCol = mnCounterCol;
            if (mnCounterRow <= mnModeSquareRow)
            {
                nRow = mnCounterRow - (mnModeSquareRow - 7) + 1;
                if (nRow > 0)
                {
                    nRow = 9 - nRow;
                    fStick2(nCol, nRow, 7,mnCounterRotate);
                }
            }


            PictureBox _pic = new PictureBox { };
            fPeek(_ModeSquare1[0], _ModeRotate1[0], ref _pic);
            pic11.Image = _pic.Image;
            fPeek(_ModeSquare1[1], _ModeRotate1[1], ref _pic);
            pic12.Image = _pic.Image;
            fPeek(_ModeSquare1[2], _ModeRotate1[2], ref _pic);
            pic13.Image = _pic.Image;
            fPeek(_ModeSquare1[3], _ModeRotate1[3], ref _pic);
            pic14.Image = _pic.Image;
            fPeek(_ModeSquare1[4], _ModeRotate1[4], ref _pic);
            pic15.Image = _pic.Image;
            fPeek(_ModeSquare1[5], _ModeRotate1[5], ref _pic);
            pic16.Image = _pic.Image;
            fPeek(_ModeSquare1[6], _ModeRotate1[6], ref _pic);
            pic17.Image = _pic.Image;
            fPeek(_ModeSquare1[7], _ModeRotate1[7], ref _pic);
            pic18.Image = _pic.Image;


            //col2 now
            fPeek(_ModeSquare2[0], _ModeRotate2[0], ref _pic);
            pic21.Image = _pic.Image;
            fPeek(_ModeSquare2[1], _ModeRotate2[1], ref _pic);
            pic22.Image = _pic.Image;
            fPeek(_ModeSquare2[2], _ModeRotate2[2], ref _pic);
            pic23.Image = _pic.Image;
            fPeek(_ModeSquare2[3], _ModeRotate2[3], ref _pic);
            pic24.Image = _pic.Image;
            fPeek(_ModeSquare2[4], _ModeRotate2[4], ref _pic);
            pic25.Image = _pic.Image;
            fPeek(_ModeSquare2[5], _ModeRotate2[5], ref _pic);
            pic26.Image = _pic.Image;
            fPeek(_ModeSquare2[6], _ModeRotate2[6], ref _pic);
            pic27.Image = _pic.Image;
            fPeek(_ModeSquare2[7], _ModeRotate2[7], ref _pic);
            pic28.Image = _pic.Image;


            //col3 now
            fPeek(_ModeSquare3[0], _ModeRotate3[0], ref _pic);
            pic31.Image = _pic.Image;
            fPeek(_ModeSquare3[1], _ModeRotate3[1], ref _pic);
            pic32.Image = _pic.Image;
            fPeek(_ModeSquare3[2], _ModeRotate3[2], ref _pic);
            pic33.Image = _pic.Image;
            fPeek(_ModeSquare3[3], _ModeRotate3[3], ref _pic);
            pic34.Image = _pic.Image;
            fPeek(_ModeSquare3[4], _ModeRotate3[4], ref _pic);
            pic35.Image = _pic.Image;
            fPeek(_ModeSquare3[5], _ModeRotate3[5], ref _pic);
            pic36.Image = _pic.Image;
            fPeek(_ModeSquare3[6], _ModeRotate3[6], ref _pic);
            pic37.Image = _pic.Image;
            fPeek(_ModeSquare3[7], _ModeRotate3[7], ref _pic);
            pic38.Image = _pic.Image;


            //col4 now
            fPeek(_ModeSquare4[0], _ModeRotate4[0], ref _pic);
            pic41.Image = _pic.Image;
            fPeek(_ModeSquare4[1], _ModeRotate4[1], ref _pic);
            pic42.Image = _pic.Image;
            fPeek(_ModeSquare4[2], _ModeRotate4[2], ref _pic);
            pic43.Image = _pic.Image;
            fPeek(_ModeSquare4[3], _ModeRotate4[3], ref _pic);
            pic44.Image = _pic.Image;
            fPeek(_ModeSquare4[4], _ModeRotate4[4], ref _pic);
            pic45.Image = _pic.Image;
            fPeek(_ModeSquare4[5], _ModeRotate4[5], ref _pic);
            pic46.Image = _pic.Image;
            fPeek(_ModeSquare4[6], _ModeRotate4[6], ref _pic);
            pic47.Image = _pic.Image;
            fPeek(_ModeSquare4[7], _ModeRotate4[7], ref _pic);
            pic48.Image = _pic.Image;


            //col5 now
            fPeek(_ModeSquare5[0], _ModeRotate5[0], ref _pic);
            pic51.Image = _pic.Image;
            fPeek(_ModeSquare5[1], _ModeRotate5[1], ref _pic);
            pic52.Image = _pic.Image;
            fPeek(_ModeSquare5[2], _ModeRotate5[2], ref _pic);
            pic53.Image = _pic.Image;
            fPeek(_ModeSquare5[3], _ModeRotate5[3], ref _pic);
            pic54.Image = _pic.Image;
            fPeek(_ModeSquare5[4], _ModeRotate5[4], ref _pic);
            pic55.Image = _pic.Image;
            fPeek(_ModeSquare5[5], _ModeRotate5[5], ref _pic);
            pic56.Image = _pic.Image;
            fPeek(_ModeSquare5[6], _ModeRotate5[6], ref _pic);
            pic57.Image = _pic.Image;
            fPeek(_ModeSquare5[7], _ModeRotate5[7], ref _pic);
            pic58.Image = _pic.Image;


            //col6 now
            fPeek(_ModeSquare6[0], _ModeRotate6[0], ref _pic);
            pic61.Image = _pic.Image;
            fPeek(_ModeSquare6[1], _ModeRotate6[1], ref _pic);
            pic62.Image = _pic.Image;
            fPeek(_ModeSquare6[2], _ModeRotate6[2], ref _pic);
            pic63.Image = _pic.Image;
            fPeek(_ModeSquare6[3], _ModeRotate6[3], ref _pic);
            pic64.Image = _pic.Image;
            fPeek(_ModeSquare6[4], _ModeRotate6[4], ref _pic);
            pic65.Image = _pic.Image;
            fPeek(_ModeSquare6[5], _ModeRotate6[5], ref _pic);
            pic66.Image = _pic.Image;
            fPeek(_ModeSquare6[6], _ModeRotate6[6], ref _pic);
            pic67.Image = _pic.Image;
            fPeek(_ModeSquare6[7], _ModeRotate6[7], ref _pic);
            pic68.Image = _pic.Image;


            //col7 now
            fPeek(_ModeSquare7[0], _ModeRotate7[0], ref _pic);
            pic71.Image = _pic.Image;
            fPeek(_ModeSquare7[1], _ModeRotate7[1], ref _pic);
            pic72.Image = _pic.Image;
            fPeek(_ModeSquare7[2], _ModeRotate7[2], ref _pic);
            pic73.Image = _pic.Image;
            fPeek(_ModeSquare7[3], _ModeRotate7[3], ref _pic);
            pic74.Image = _pic.Image;
            fPeek(_ModeSquare7[4], _ModeRotate7[4], ref _pic);
            pic75.Image = _pic.Image;
            fPeek(_ModeSquare7[5], _ModeRotate7[5], ref _pic);
            pic76.Image = _pic.Image;
            fPeek(_ModeSquare7[6], _ModeRotate7[6], ref _pic);
            pic77.Image = _pic.Image;
            fPeek(_ModeSquare7[7], _ModeRotate7[7], ref _pic);
            pic78.Image = _pic.Image;


            //col8 now
            fPeek(_ModeSquare8[0], _ModeRotate8[0], ref _pic);
            pic81.Image = _pic.Image;
            fPeek(_ModeSquare8[1], _ModeRotate8[1], ref _pic);
            pic82.Image = _pic.Image;
            fPeek(_ModeSquare8[2], _ModeRotate8[2], ref _pic);
            pic83.Image = _pic.Image;
            fPeek(_ModeSquare8[3], _ModeRotate8[3], ref _pic);
            pic84.Image = _pic.Image;
            fPeek(_ModeSquare8[4], _ModeRotate8[4], ref _pic);
            pic85.Image = _pic.Image;
            fPeek(_ModeSquare8[5], _ModeRotate8[5], ref _pic);
            pic86.Image = _pic.Image;
            fPeek(_ModeSquare8[6], _ModeRotate8[6], ref _pic);
            pic87.Image = _pic.Image;
            fPeek(_ModeSquare8[7], _ModeRotate8[7], ref _pic);
            pic88.Image = _pic.Image;
        }

        private void fUpdateCounter()
        {
            int nCol, nRow;

            nCol = mnCounterCol;
            if (mnCounterRow <= mnModeSquareRow)
            {
                nRow = mnCounterRow - (mnModeSquareRow - 7) + 1;
                if (nRow > 0)
                {
                    nRow = 9 - nRow;
                    fStick2(nCol, nRow, 7, mnCounterRotate);
                }
            }
            else
            {
                return;
            }


            PictureBox _pic = new PictureBox { };

            switch (nCol)
            {
                case 1:
                    fPeek(_ModeSquare1[nRow-1], _ModeRotate1[nRow-1], ref _pic);
                    switch (nRow)
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
                    fPeek(_ModeSquare2[nRow - 1], _ModeRotate2[nRow - 1], ref _pic);
                    switch (nRow)
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
                    fPeek(_ModeSquare3[nRow - 1], _ModeRotate3[nRow - 1], ref _pic);
                    switch (nRow)
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
                    fPeek(_ModeSquare4[nRow - 1], _ModeRotate4[nRow - 1], ref _pic);
                    switch (nRow)
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
                    fPeek(_ModeSquare5[nRow - 1], _ModeRotate5[nRow - 1], ref _pic);
                    switch (nRow)
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
                    fPeek(_ModeSquare6[nRow - 1], _ModeRotate6[nRow - 1], ref _pic);
                    switch (nRow)
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
                    fPeek(_ModeSquare7[nRow - 1], _ModeRotate7[nRow - 1], ref _pic);
                    switch (nRow)
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
                case 8:
                    fPeek(_ModeSquare8[nRow - 1], _ModeRotate8[nRow - 1], ref _pic);
                    switch (nRow)
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


        private void fStick(int nCol,int nRow,int nType,int nRotate)
        {
            switch (nCol)
            {
                case 1:
                    _col1[nRow - 1] = nType;
                    _rotate1[nRow - 1] = nRotate;
                    break;
                case 2:
                    _col2[nRow - 1] = nType;
                    _rotate2[nRow - 1] = nRotate;
                    break;
                case 3:
                    _col3[nRow - 1] = nType;
                    _rotate3[nRow - 1] = nRotate;
                    break;
                case 4:
                    _col4[nRow - 1] = nType;
                    _rotate4[nRow - 1] = nRotate;
                    break;
                case 5:
                    _col5[nRow - 1] = nType;
                    _rotate5[nRow - 1] = nRotate;
                    break;
                case 6:
                    _col6[nRow - 1] = nType;
                    _rotate6[nRow - 1] = nRotate;
                    break;
                case 7:
                    _col7[nRow - 1] = nType;
                    _rotate7[nRow - 1] = nRotate;
                    break;
                default:
                    _col8[nRow - 1] = nType;
                    _rotate8[nRow - 1] = nRotate;
                    break;
            }
        }
        private void fStick2(int nCol, int nRow, int nType, int nRotate)
        {
            switch (nCol)
            {
                case 1:
                    _ModeSquare1[nRow - 1] = nType;
                    _ModeRotate1[nRow - 1] = nRotate;
                    break;
                case 2:
                    _ModeSquare2[nRow - 1] = nType;
                    _ModeRotate2[nRow - 1] = nRotate;
                    break;
                case 3:
                    _ModeSquare3[nRow - 1] = nType;
                    _ModeRotate3[nRow - 1] = nRotate;
                    break;
                case 4:
                    _ModeSquare4[nRow - 1] = nType;
                    _ModeRotate4[nRow - 1] = nRotate;
                    break;
                case 5:
                    _ModeSquare5[nRow - 1] = nType;
                    _ModeRotate5[nRow - 1] = nRotate;
                    break;
                case 6:
                    _ModeSquare6[nRow - 1] = nType;
                    _ModeRotate6[nRow - 1] = nRotate;
                    break;
                case 7:
                    _ModeSquare7[nRow - 1] = nType;
                    _ModeRotate7[nRow - 1] = nRotate;
                    break;
                default:
                    _ModeSquare8[nRow - 1] = nType;
                    _ModeRotate8[nRow - 1] = nRotate;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();

            nScore = 0;
            lblScore.Text = "Score = 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            mnModeSquareRow = rnd1.Next(8,31);
            lblRow.Text = "Row " + Convert.ToString(mnModeSquareRow) + "/30";
            fReset();
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            if (mnCounterRow == mnModeSquareRow)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnCounterRow += 1;
                mnCounterRotate = 1;
                fCopy();
                fTake(mnCounterCol, mnCounterRow);
                // fUpdateCounter ();
            }
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            if (mnCounterCol == 8)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnCounterCol += 1;
                mnCounterRotate = 2;
                fCopy();
                fTake(mnCounterCol, mnCounterRow);
                //fUpdateCounter();
            }

        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            if (mnCounterRow == mnModeSquareRow-7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnCounterRow -= 1;
                mnCounterRotate = 3;
                fCopy();
                fTake(mnCounterCol,mnCounterRow);
                // fUpdateCounter();
            }

        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            if (mnCounterCol == 1)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnCounterCol -= 1;
                mnCounterRotate = 4;
                fCopy();
                fTake(mnCounterCol, mnCounterRow);
                // fUpdateCounter();
            }

        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            int nCol = mnCounterCol;
            int nRow = mnCounterRow;
            int nType, nSteps ;

            if (mnCounterRow > 30)
            {
                Random rnd1 = new Random();
                mnModeSquareRow = rnd1.Next(8, 31);
                lblRow.Text = "Row " + Convert.ToString(mnModeSquareRow) + "/30";
                fReset();
                return;
            }
            nType = fType(nCol, nRow);
            nSteps = 0;
            if (nType == 6)
            {
                nSteps = mnCounterRow -(mnModeSquareRow-7);
                mnModeSquareRow += nSteps;
                lblRow.Text = "Row " + Convert.ToString(mnModeSquareRow) + "/30";
                fCopy();
                fUpdateDisplay();
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            mbTake = true;
        }

        private void btnUpdateDisplay_Click(object sender, EventArgs e)
        {
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            mnModeSquareRow = rnd1.Next(8, 31);
            lblRow.Text = "Row " + Convert.ToString(mnModeSquareRow) + "/30";
            fReset();
        }
    }
}
