using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoleculesAgain
{
    public partial class fSub1 : Form
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _rotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private List<int> _nStage = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _Level = new List<int> { 0, 0, 0, 0, 0, 0 , 0, 0, 0, 0, 0, 0 };
        private List<String> _sStage = new List<String> { null,null,null,null,null,null };
        private int mnTreat;
        private int nScore;

        private void fLevel()
        {
            String sStage = null;
            int nLength;
            String sColour;
            int nColour;

            for (int i = 7; i <= 12; i++)
            {
                _Level[i - 1] = 0;
            }
            for (int i = 1; i <= 6; i++)
            {
                sStage = _sStage[i - 1];
                if (sStage == null)
                {
                    continue;
                }
                nLength = sStage.Length;
                for (int j = 1; j <= nLength; j++)
                {
                    sColour = sStage.Substring(j - 1, 1);
                    nColour = Convert.ToInt32(sColour) + 6;
                    _Level[nColour - 1] = i;
                }
            }
        }

        private int fLevel2(int nType)
        {
            int nLevel = _Level[nType - 1];

            return nLevel;
         }

        private void fClick(int nCol,int nRow)
        {
            Random rnd1 = new Random();
            int nType = fType(nCol, nRow);
            int nLevel,nLevel2;
            int nType2 = mnTreat;
            
            if (nType <= 6)
            {
                MessageBox.Show("Error!");
                return;
            }
            if (nType >= 13)
            {
                MessageBox.Show("Error!");
                return;
            }

            nLevel = fLevel2(nType);
            nLevel2 = fLevel2(nType2);
            if (nLevel2 == nLevel + 1)
            {
                fStick(nCol, nRow, nType2, rnd1.Next(1, 5));
                fUpdateDisplay();
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
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

        private void fStick( int nCol, int nRow, int nType, int nRotate)
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


        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F ballmolecule.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F casings.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F correspondingcastings1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F correspondingcastings2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F field1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F field2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F m_blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F m_green.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F m_orange.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F m_purple.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F m_red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F m_yellow.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F spark_clothes.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F spark_equipment.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F spark_food.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F spark_machines.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
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
                case 16:
                    _pic2 = picture16;
                    break;
                default:
                    _pic2 = picture17;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;
         
            nType = _col1[0];
            nRotate = _rotate1[0];
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = _col1[1];
            nRotate = _rotate1[1];
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = _col1[2];
            nRotate = _rotate1[2];
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = _col1[3];
            nRotate = _rotate1[3];
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
            nType = _col1[4];
            nRotate = _rotate1[4];
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = _col1[5];
            nRotate = _rotate1[5];
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = _col1[6];
            nRotate = _rotate1[6];
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = _col1[7];
            nRotate = _rotate1[7];
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            nType = _col2[0];
            nRotate = _rotate2[0];
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = _col2[1];
            nRotate = _rotate2[1];
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = _col2[2];
            nRotate = _rotate2[2];
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = _col2[3];
            nRotate = _rotate2[3];
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = _col2[4];
            nRotate = _rotate2[4];
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = _col2[5];
            nRotate = _rotate2[5];
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = _col2[6];
            nRotate = _rotate2[6];
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = _col2[7];
            nRotate = _rotate2[7];
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            nType = _col3[0];
            nRotate = _rotate3[0];
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = _col3[1];
            nRotate = _rotate3[1];
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = _col3[2];
            nRotate = _rotate3[2];
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = _col3[3];
            nRotate = _rotate3[3];
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = _col3[4];
            nRotate = _rotate3[4];
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = _col3[5];
            nRotate = _rotate3[5];
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = _col3[6];
            nRotate = _rotate3[6];
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = _col3[7];
            nRotate = _rotate3[7];
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            nType = _col4[0];
            nRotate = _rotate4[0];
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = _col4[1];
            nRotate = _rotate4[1];
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = _col4[2];
            nRotate = _rotate4[2];
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = _col4[3];
            nRotate = _rotate4[3];
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = _col4[4];
            nRotate = _rotate4[4];
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = _col4[5];
            nRotate = _rotate4[5];
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = _col4[6];
            nRotate = _rotate4[6];
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = _col4[7];
            nRotate = _rotate4[7];
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            nType = _col5[0];
            nRotate = _rotate5[0];
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = _col5[1];
            nRotate = _rotate5[1];
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = _col5[2];
            nRotate = _rotate5[2];
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = _col5[3];
            nRotate = _rotate5[3];
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = _col5[4];
            nRotate = _rotate5[4];
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = _col5[5];
            nRotate = _rotate5[5];
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = _col5[6];
            nRotate = _rotate5[6];
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = _col5[7];
            nRotate = _rotate5[7];
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

            nType = _col6[0];
            nRotate = _rotate6[0];
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = _col6[1];
            nRotate = _rotate6[1];
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = _col6[2];
            nRotate = _rotate6[2];
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = _col6[3];
            nRotate = _rotate6[3];
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;
            nType = _col6[4];
            nRotate = _rotate6[4];
            fPeek(nType, nRotate, ref _pic);
            pic65.Image = _pic.Image;
            nType = _col6[5];
            nRotate = _rotate6[5];
            fPeek(nType, nRotate, ref _pic);
            pic66.Image = _pic.Image;
            nType = _col6[6];
            nRotate = _rotate6[6];
            fPeek(nType, nRotate, ref _pic);
            pic67.Image = _pic.Image;
            nType = _col6[7];
            nRotate = _rotate6[7];
            fPeek(nType, nRotate, ref _pic);
            pic68.Image = _pic.Image;

            nType = _col7[0];
            nRotate = _rotate7[0];
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = _col7[1];
            nRotate = _rotate7[1];
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = _col7[2];
            nRotate = _rotate7[2];
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = _col7[3];
            nRotate = _rotate7[3];
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;
            nType = _col7[4];
            nRotate = _rotate7[4];
            fPeek(nType, nRotate, ref _pic);
            pic75.Image = _pic.Image;
            nType = _col7[5];
            nRotate = _rotate7[5];
            fPeek(nType, nRotate, ref _pic);
            pic76.Image = _pic.Image;
            nType = _col7[6];
            nRotate = _rotate7[6];
            fPeek(nType, nRotate, ref _pic);
            pic77.Image = _pic.Image;
            nType = _col7[7];
            nRotate = _rotate7[7];
            fPeek(nType, nRotate, ref _pic);
            pic78.Image = _pic.Image;

            nType = _col8[0];
            nRotate = _rotate8[0];
            fPeek(nType, nRotate, ref _pic);
            pic81.Image = _pic.Image;
            nType = _col8[1];
            nRotate = _rotate8[1];
            fPeek(nType, nRotate, ref _pic);
            pic82.Image = _pic.Image;
            nType = _col8[2];
            nRotate = _rotate8[2];
            fPeek(nType, nRotate, ref _pic);
            pic83.Image = _pic.Image;
            nType = _col8[3];
            nRotate = _rotate8[3];
            fPeek(nType, nRotate, ref _pic);
            pic84.Image = _pic.Image;
            nType = _col8[4];
            nRotate = _rotate8[4];
            fPeek(nType, nRotate, ref _pic);
            pic85.Image = _pic.Image;
            nType = _col8[5];
            nRotate = _rotate8[5];
            fPeek(nType, nRotate, ref _pic);
            pic86.Image = _pic.Image;
            nType = _col8[6];
            nRotate = _rotate8[6];
            fPeek(nType, nRotate, ref _pic);
            pic87.Image = _pic.Image;
            nType = _col8[7];
            nRotate = _rotate8[7];
            fPeek(nType, nRotate, ref _pic);
            pic88.Image = _pic.Image;
        }

        private void fRuling()
        {
            Random rnd1 = new Random();
            String sLeft = "123456";
            String sText = null;
            String sNew = null;
            int nPos;
            int nLength;
            int nMax,nCount;

            mnTreat = 7;

            for (int i = 1; i <= 6; i++)
            {
                _nStage[i - 1] = 0;
            }

            nLength = sLeft.Length;
            nPos = rnd1.Next(1, 7);
            sText = sLeft.Substring(nPos - 1, 1);
            sLeft = sLeft.Substring(0, nPos - 1) + sLeft.Substring(nPos, nLength - nPos);

            nLength = sLeft.Length;
            nMax = nLength * 2;
            _sStage[0] = sText;
            _nStage[0] = 1;

            nMax = rnd1.Next(1, nMax + 1);
            nCount = 0;
            sNew = null;
            for (int i = 1; i <= nMax; i++)
            {
                nLength = sLeft.Length;
                nCount += 1;
                if (nLength == 0)
                {
                    nCount -= 1;
                    continue;
                }
                nPos = rnd1.Next(1, nLength+1);
                sNew = sNew+sLeft.Substring(nPos - 1, 1);
                sLeft = sLeft.Substring(0, nPos - 1) + sLeft.Substring(nPos, nLength - nPos);
          
            }
            if (nLength == 0)
            {
                _sStage[1] = sNew;
                _nStage[1] = nCount;
                goto g_end;
            }

            _sStage[1] = sNew;
                _nStage[1] = nMax;

                nLength = sLeft.Length;
                nMax = nLength * 2;
                nMax = rnd1.Next(1, nMax + 1);
                nCount = 0;
                sNew = null;
                for (int i = 1; i <= nMax; i++)
                {
                    nLength = sLeft.Length;
                    nCount += 1;
                    if (nLength == 0)
                    {
                        nCount -= 1;
                        continue;
                    }
                    nPos = rnd1.Next(1, nLength + 1);
                    sNew = sNew + sLeft.Substring(nPos - 1, 1);
                    sLeft = sLeft.Substring(0, nPos - 1) + sLeft.Substring(nPos, nLength - nPos);

                }

            if (nLength == 0)
            {
                _sStage[2] = sNew;
                _nStage[2] = nCount;
                goto g_end;
            }

            _sStage[2] = sNew;
            _nStage[2] = nMax;

            nLength = sLeft.Length;
            nMax = nLength * 2;
            nMax = rnd1.Next(1, nMax + 1);
            nCount = 0;
            sNew = null;
            for (int i = 1; i <= nMax; i++)
            {
                nLength = sLeft.Length;
                nCount += 1;
                if (nLength == 0)
                {
                    nCount -= 1;
                    continue;
                }
                nPos = rnd1.Next(1, nLength + 1);
                sNew = sNew + sLeft.Substring(nPos - 1, 1);
                sLeft = sLeft.Substring(0, nPos - 1) + sLeft.Substring(nPos, nLength - nPos);

            }

            if (nLength == 0)
            {
                _sStage[3] = sNew;
                _nStage[3] = nCount;
                goto g_end;
            }

            _sStage[3] = sNew;
            _nStage[3] = nMax;

            nLength = sLeft.Length;
            nMax = nLength * 2;
            nMax = rnd1.Next(1, nMax + 1);
            nCount = 0;
            sNew = null;
            for (int i = 1; i <= nMax; i++)
            {
                nLength = sLeft.Length;
                nCount += 1;
                if (nLength == 0)
                {
                    nCount -= 1;
                    continue;
                }
                nPos = rnd1.Next(1, nLength + 1);
                sNew = sNew + sLeft.Substring(nPos - 1, 1);
                sLeft = sLeft.Substring(0, nPos - 1) + sLeft.Substring(nPos, nLength - nPos);

            }

            if (nLength == 0)
            {
                _sStage[4] = sNew;
                _nStage[4] = nCount;
                goto g_end;
            }

            _sStage[4] = sNew;
            _nStage[4] = nMax;

            nLength = sLeft.Length;
            nMax = nLength * 2;
            nMax = rnd1.Next(1, nMax + 1);
            nCount = 0;
            sNew = null;
            for (int i = 1; i <= nMax; i++)
            {
                nLength = sLeft.Length;
                nCount += 1;
                if (nLength == 0)
                {
                    nCount -= 1;
                    continue;
                }
                nPos = rnd1.Next(1, nLength + 1);
                sNew = sNew + sLeft.Substring(nPos - 1, 1);
                sLeft = sLeft.Substring(0, nPos - 1) + sLeft.Substring(nPos, nLength - nPos);

            }

            if (nLength == 0)
            {
                _sStage[5] = sNew;
                _nStage[5] = nCount;
                goto g_end;
            }

            _sStage[5] = sNew;
            _nStage[5] = nMax;

            nLength = sLeft.Length;
            nMax = nLength * 2;
            nMax = rnd1.Next(1, nMax + 1);
            nCount = 0;
            sNew = null;
            for (int i = 1; i <= nMax; i++)
            {
                nLength = sLeft.Length;
                nCount += 1;
                if (nLength == 0)
                {
                    nCount -= 1;
                    continue;
                }
                nPos = rnd1.Next(1, nLength + 1);
                sNew = sNew + sLeft.Substring(nPos - 1, 1);
                sLeft = sLeft.Substring(0, nPos - 1) + sLeft.Substring(nPos, nLength - nPos);

            }

            g_end:

            if (lstRuling.Items.Count > 0)
            {
                do
                {
                    lstRuling.Items.RemoveAt(0);
                } while (lstRuling.Items.Count > 0);
            }

            lstRuling.Items.Add("BGOPRY");
            for (int i = 1; i <= 6; i++)
            {
                sText = _sStage[i - 1];
                if (sText == null)
                {
                    continue;
                }
                else
                {
                    lstRuling.Items.Add(_sStage[i - 1]);
                }
            }

            fLevel();
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nBalls = rnd1.Next(4, 13);
            int nCol, nRow;

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 5)
                    {
                        fStick( i, j, 5, rnd1.Next(1, 5));
                    }
                    else
                    {
                        fStick( i, j, 6, rnd1.Next(1, 5));
                    }
                }
            }

            for (int i = 1; i <= nBalls; i++)
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                fStick(nCol, nRow, rnd1.Next(7, 13), rnd1.Next(1, 5));
            }

            fRuling();
        }

        public fSub1()
        {
            InitializeComponent();
            nScore = 0;
            lblScore.Text = "Score = 0";
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();

        }

        private void picTreat7_Click(object sender, EventArgs e)
        {
            mnTreat = 7;

        }

        private void picTreat8_Click(object sender, EventArgs e)
        {
            mnTreat = 8;

        }

        private void picTreat9_Click(object sender, EventArgs e)
        {
            mnTreat = 9;

        }

        private void picTreat10_Click(object sender, EventArgs e)
        {
            mnTreat = 10;

        }

        private void picTreat11_Click(object sender, EventArgs e)
        {
            mnTreat = 11;

        }

        private void picTreat12_Click(object sender, EventArgs e)
        {
            mnTreat = 12;

        }


        private void pic11_Click(object sender, EventArgs e)
        {
            fClick(1, 1);
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            fClick(1, 2);
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            fClick(1, 3);
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            fClick(1, 4);

        }

        private void pic15_Click(object sender, EventArgs e)
        {
            fClick(1, 5);

        }

        private void pic16_Click(object sender, EventArgs e)
        {
            fClick(1, 6);

        }

        private void pic17_Click(object sender, EventArgs e)
        {
            fClick(1, 7);

        }

        private void pic18_Click(object sender, EventArgs e)
        {
            fClick(1, 8);

        }

        private void pic21_Click(object sender, EventArgs e)
        {
            fClick(2, 1);

        }

        private void pic22_Click(object sender, EventArgs e)
        {
            fClick(2, 2);
        }

        private void pic23_Click(object sender, EventArgs e)
        {
            fClick(2, 3);
        }

        private void pic24_Click(object sender, EventArgs e)
        {
            fClick(2, 4);
        }

        private void pic25_Click(object sender, EventArgs e)
        {
            fClick(2, 5);
        }

        private void pic26_Click(object sender, EventArgs e)
        {
            fClick(2, 6);
        }

        private void pic27_Click(object sender, EventArgs e)
        {
            fClick(2, 7);
        }

        private void pic28_Click(object sender, EventArgs e)
        {
            fClick(2, 8);
        }

        private void pic31_Click(object sender, EventArgs e)
        {
            fClick(3, 1);
        }

        private void pic32_Click(object sender, EventArgs e)
        {
            fClick(3, 2);
        }

        private void pic33_Click(object sender, EventArgs e)
        {
            fClick(3, 3);
        }

        private void pic34_Click(object sender, EventArgs e)
        {
            fClick(3, 4);
        }

        private void pic35_Click(object sender, EventArgs e)
        {
            fClick(3, 5);
        }

        private void pic36_Click(object sender, EventArgs e)
        {
            fClick(3, 6);
        }

        private void pic37_Click(object sender, EventArgs e)
        {
            fClick(3, 7);
        }

        private void pic38_Click(object sender, EventArgs e)
        {
            fClick(3, 8);
        }

        private void pic41_Click(object sender, EventArgs e)
        {
            fClick(4, 1);
        }

        private void pic42_Click(object sender, EventArgs e)
        {
            fClick(4, 2);
        }

        private void pic43_Click(object sender, EventArgs e)
        {
            fClick(4, 3);
        }

        private void pic44_Click(object sender, EventArgs e)
        {
            fClick(4, 4);
        }

        private void pic45_Click(object sender, EventArgs e)
        {
            fClick(4, 5);
        }

        private void pic46_Click(object sender, EventArgs e)
        {
            fClick(4, 6);
        }

        private void pic47_Click(object sender, EventArgs e)
        {
            fClick(4, 7);
        }

        private void pic48_Click(object sender, EventArgs e)
        {
            fClick(4, 8);
        }

        private void pic51_Click(object sender, EventArgs e)
        {
            fClick(5, 1);
        }

        private void pic52_Click(object sender, EventArgs e)
        {
            fClick(5, 2);
        }

        private void pic53_Click(object sender, EventArgs e)
        {
            fClick(5, 3);
        }

        private void pic54_Click(object sender, EventArgs e)
        {
            fClick(5, 4);
        }

        private void pic55_Click(object sender, EventArgs e)
        {
            fClick(5, 5);
        }

        private void pic56_Click(object sender, EventArgs e)
        {
            fClick(5, 6);
        }

        private void pic57_Click(object sender, EventArgs e)
        {
            fClick(5, 7);
        }

        private void pic58_Click(object sender, EventArgs e)
        {
            fClick(5, 8);
        }

        private void pic61_Click(object sender, EventArgs e)
        {
            fClick(6, 1);
        }

        private void pic62_Click(object sender, EventArgs e)
        {
            fClick(6, 2);
        }

        private void pic63_Click(object sender, EventArgs e)
        {
            fClick(6, 3);
        }

        private void pic64_Click(object sender, EventArgs e)
        {
            fClick(6, 4);
        }

        private void pic65_Click(object sender, EventArgs e)
        {
            fClick(6, 5);
        }

        private void pic66_Click(object sender, EventArgs e)
        {
            fClick(6, 6);
        }

        private void pic67_Click(object sender, EventArgs e)
        {
            fClick(6, 7);
        }

        private void pic68_Click(object sender, EventArgs e)
        {
            fClick(6, 8);
        }

        private void pic71_Click(object sender, EventArgs e)
        {
            fClick(7, 1);
        }

        private void pic72_Click(object sender, EventArgs e)
        {
            fClick(7, 2);
        }

        private void pic73_Click(object sender, EventArgs e)
        {
            fClick(7, 3);
        }

        private void pic74_Click(object sender, EventArgs e)
        {
            fClick(7, 4);
        }

        private void pic75_Click(object sender, EventArgs e)
        {
            fClick(7, 5);
        }

        private void pic76_Click(object sender, EventArgs e)
        {
            fClick(7, 6);
        }

        private void pic77_Click(object sender, EventArgs e)
        {
            fClick(7, 7);
        }

        private void pic78_Click(object sender, EventArgs e)
        {
            fClick(7, 8);
        }

        private void pic81_Click(object sender, EventArgs e)
        {
            fClick(8, 1);
        }

        private void pic82_Click(object sender, EventArgs e)
        {
            fClick(8, 2);
        }

        private void pic83_Click(object sender, EventArgs e)
        {
            fClick(8, 3);
        }

        private void pic84_Click(object sender, EventArgs e)
        {
            fClick(8, 4);
        }

        private void pic85_Click(object sender, EventArgs e)
        {
            fClick(8, 5);
        }

        private void pic86_Click(object sender, EventArgs e)
        {
            fClick(8, 6);
        }

        private void pic87_Click(object sender, EventArgs e)
        {
            fClick(8, 7);
        }

        private void pic88_Click(object sender, EventArgs e)
        {
            fClick(8, 8);
        }
    }
}
