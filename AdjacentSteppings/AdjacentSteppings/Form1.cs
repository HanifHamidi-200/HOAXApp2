using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdjacentSteppings
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
        private static List<int> _HP1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HP2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HP3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HP4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HP5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HP6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HP7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HP8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _playercol = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _playerrow = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _playerHP = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _playerSP = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _playerAC = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private int mnYOU, mnEnemy;
        private int mnCol, mnRow;
        private int mnSavecol, mnSaverow;
        private bool mbPlayer;
        private int mnPlayers,mnPlayer;
        private int mnMovesleft;
        private bool mbUsearrow;
        private int mnKillCol, mnKillRow;

        private void fCellNext(ref int nCol,ref int nRow)
        {
            Random rnd1 = new Random();
            int nDirection = rnd1.Next(1, 9);
            bool bFound = false;

            switch (nDirection)
            {
                case 1:
                    nRow -= 1;
                    break;
                case 2:
                    nCol += 1;
                    nRow -= 1;
                    break;
                case 3:
                    nCol += 1;
                    break;
                case 4:
                    nCol += 1;
                    nRow += 1;
                    break;
                case 5:
                    nRow += 1;
                    break;
                case 6:
                    nCol -= 1;
                    nRow += 1;
                    break;
                case 7:
                    nCol -= 1;
                    break;
                default:
                    nCol -= 1;
                    nRow -= 1;
                    break;
            }
            if (nCol == 0)
            {
                bFound = true;
            }
            if (nCol == 9)
            {
                bFound = true;
            }
            if (nRow == 0)
            {
                bFound = true;
            }
            if (nRow == 9)
            {
                bFound = true;
            }
            if (bFound)
            {
                nCol = 0;
                nRow = 0;
            }
        }
        private void fHighlightOn(int nCol,int nRow)
        {
            int nType = 0;

            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    switch (nType)
                    {
                        case 2:
                            nType = 3;
                            break;
                        case 7:
                            nType = 8;
                            break;
                        case 3:
                             break;
                        case 8:
                             break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col1[nRow - 1]=nType;
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    switch (nType)
                    {
                        case 2:
                            nType = 3;
                            break;
                        case 7:
                            nType = 8;
                            break;
                        case 3:
                            break;
                        case 8:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col2[nRow - 1] = nType;
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    switch (nType)
                    {
                        case 2:
                            nType = 3;
                            break;
                        case 7:
                            nType = 8;
                            break;
                        case 3:
                            break;
                        case 8:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col3[nRow - 1] = nType;
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    switch (nType)
                    {
                        case 2:
                            nType = 3;
                            break;
                        case 7:
                            nType = 8;
                            break;
                        case 3:
                            break;
                        case 8:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col4[nRow - 1] = nType;
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    switch (nType)
                    {
                        case 2:
                            nType = 3;
                            break;
                        case 7:
                            nType = 8;
                            break;
                        case 3:
                            break;
                        case 8:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col5[nRow - 1] = nType;
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    switch (nType)
                    {
                        case 2:
                            nType = 3;
                            break;
                        case 7:
                            nType = 8;
                            break;
                        case 3:
                            break;
                        case 8:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col6[nRow - 1] = nType;
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    switch (nType)
                    {
                        case 2:
                            nType = 3;
                            break;
                        case 7:
                            nType = 8;
                            break;
                        case 3:
                            break;
                        case 8:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col7[nRow - 1] = nType;
                    break;
                default:
                    nType = _col8[nRow - 1];
                    switch (nType)
                    {
                        case 2:
                            nType = 3;
                            break;
                        case 7:
                            nType = 8;
                            break;
                        case 3:
                            break;
                        case 8:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col8[nRow - 1] = nType;
                    break;
            }
            fUpdateDisplay();
        }

        private void fHighlightOff(int nCol, int nRow)
        {
            int nType = 0;

            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    switch (nType)
                    {
                        case 3:
                            nType = 2;
                            break;
                        case 8:
                            nType = 7;
                            break;
                        case 2:
                            break;
                        case 7:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col1[nRow - 1] = nType;
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    switch (nType)
                    {
                        case 3:
                            nType = 2;
                            break;
                        case 8:
                            nType = 7;
                            break;
                        case 2:
                            break;
                        case 7:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col2[nRow - 1] = nType;
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    switch (nType)
                    {
                        case 3:
                            nType = 2;
                            break;
                        case 8:
                            nType = 7;
                            break;
                        case 2:
                            break;
                        case 7:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col3[nRow - 1] = nType;
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    switch (nType)
                    {
                        case 3:
                            nType = 2;
                            break;
                        case 8:
                            nType = 7;
                            break;
                        case 2:
                            break;
                        case 7:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col4[nRow - 1] = nType;
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    switch (nType)
                    {
                        case 3:
                            nType = 2;
                            break;
                        case 8:
                            nType = 7;
                            break;
                        case 2:
                            break;
                        case 7:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col5[nRow - 1] = nType;
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    switch (nType)
                    {
                        case 3:
                            nType = 2;
                            break;
                        case 8:
                            nType = 7;
                            break;
                        case 2:
                            break;
                        case 7:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col6[nRow - 1] = nType;
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    switch (nType)
                    {
                        case 3:
                            nType = 2;
                            break;
                        case 8:
                            nType = 7;
                            break;
                        case 2:
                            break;
                        case 7:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col7[nRow - 1] = nType;
                    break;
                default:
                    nType = _col8[nRow - 1];
                    switch (nType)
                    {
                        case 3:
                            nType = 2;
                            break;
                        case 8:
                            nType = 7;
                            break;
                        case 2:
                            break;
                        case 7:
                            break;
                        default:
                            nType = 1;
                            break;
                    }
                    _col8[nRow - 1] = nType;
                    break;
            }
            fUpdateDisplay();
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;

            mnCol = rnd1.Next(1, 9);
            mnRow = rnd1.Next(1, 9);
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            mbPlayer = false;
            mnMovesleft = 0;
            lblMovesleft.Text = "MOVESLEFT = 0";

            mnYOU = rnd1.Next(4, 9);
            mnEnemy = rnd1.Next(4, 21);
            mnPlayers = mnYOU;

            for (int i = 1; i <= 8; i++)
            {
                _col1[i - 1] = 1;
                _col2[i - 1] = 1;
                _col3[i - 1] = 1;
                _col4[i - 1] = 1;
                _col5[i - 1] = 1;
                _col6[i - 1] = 1;
                _col7[i - 1] = 1;
                _col8[i - 1] = 1;
                _HP1[i - 1] = 0;
                _HP2[i - 1] = 0;
                _HP3[i - 1] = 0;
                _HP4[i - 1] = 0;
                _HP5[i - 1] = 0;
                _HP6[i - 1] = 0;
                _HP7[i - 1] = 0;
                _HP8[i - 1] = 0;
            }
            nCol = rnd1.Next(1, 9);
            nRow = rnd1.Next(1, 9);
            nType = 5;
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
            nCol = rnd1.Next(1, 9);
            nRow = rnd1.Next(1, 9);
            nType = 5;
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
            nCol = rnd1.Next(1, 9);
            nRow = rnd1.Next(1, 9);
            nType = 6;
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
            fCellNext(ref nCol, ref nRow);
            if (nCol != 0)
            {
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
                fCellNext(ref nCol, ref nRow);
                if (nCol != 0)
                {
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
            for (int i = 1; i <= mnEnemy; i++)
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                nType = 2;
                switch (nCol)
                {
                    case 1:
                        _col1[nRow - 1] = nType;
                        _HP1[nRow - 1] = rnd1.Next(10, 71);
                        break;
                    case 2:
                        _col2[nRow - 1] = nType;
                        _HP2[nRow - 1] = rnd1.Next(10, 71);
                        break;
                    case 3:
                        _col3[nRow - 1] = nType;
                        _HP3[nRow - 1] = rnd1.Next(10, 71);
                        break;
                    case 4:
                        _col4[nRow - 1] = nType;
                        _HP4[nRow - 1] = rnd1.Next(10, 71);
                        break;
                    case 5:
                        _col5[nRow - 1] = nType;
                        _HP5[nRow - 1] = rnd1.Next(10, 71);
                        break;
                    case 6:
                        _col6[nRow - 1] = nType;
                        _HP6[nRow - 1] = rnd1.Next(10, 71);
                        break;
                    case 7:
                        _col7[nRow - 1] = nType;
                        _HP7[nRow - 1] = rnd1.Next(10, 71);
                        break;
                    case 8:
                        _col8[nRow - 1] = nType;
                        _HP8[nRow - 1] = rnd1.Next(10, 71);
                        break;
                }
            }
            for (int i = 1; i <= mnYOU; i++)
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 9);
                _playercol[i - 1] = nCol;
                _playerrow[i - 1] = nRow;
                _playerHP[i - 1] = rnd1.Next(14, 61);
                _playerSP[i - 1] = rnd1.Next(0, 19);
                _playerAC[i - 1] = 2;
                nType = 7;
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
        private void fUpdateDisplay()
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F actualgrass.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F EnemyCharacter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F EnemySelected.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F PersonDying.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F stones_intheway.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F stonewall.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F YOUCharacter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F YOUSelected.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F YOUCharacter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (_col1[0])
            {
                case 1:
                    pic11.Image = picture1.Image;
                    break;
                case 2:
                    pic11.Image = picture2.Image;
                    break;
                case 3:
                    pic11.Image = picture3.Image;
                    break;
                case 4:
                    pic11.Image = picture4.Image;
                    break;
                case 5:
                    pic11.Image = picture5.Image;
                    break;
                case 6:
                    pic11.Image = picture6.Image;
                    break;
                case 7:
                    pic11.Image = picture7.Image;
                    break;
                case 8:
                    pic11.Image = picture8.Image;
                    break;
                default:
                    pic11.Image = picture9.Image;
                    break;
            }
            switch (_col1[1])
            {
                case 1:
                    pic12.Image = picture1.Image;
                    break;
                case 2:
                    pic12.Image = picture2.Image;
                    break;
                case 3:
                    pic12.Image = picture3.Image;
                    break;
                case 4:
                    pic12.Image = picture4.Image;
                    break;
                case 5:
                    pic12.Image = picture5.Image;
                    break;
                case 6:
                    pic12.Image = picture6.Image;
                    break;
                case 7:
                    pic12.Image = picture7.Image;
                    break;
                case 8:
                    pic12.Image = picture8.Image;
                    break;
                default:
                    pic12.Image = picture9.Image;
                    break;
            }
            switch (_col1[2])
            {
                case 1:
                    pic13.Image = picture1.Image;
                    break;
                case 2:
                    pic13.Image = picture2.Image;
                    break;
                case 3:
                    pic13.Image = picture3.Image;
                    break;
                case 4:
                    pic13.Image = picture4.Image;
                    break;
                case 5:
                    pic13.Image = picture5.Image;
                    break;
                case 6:
                    pic13.Image = picture6.Image;
                    break;
                case 7:
                    pic13.Image = picture7.Image;
                    break;
                case 8:
                    pic13.Image = picture8.Image;
                    break;
                default:
                    pic13.Image = picture9.Image;
                    break;
            }
            switch (_col1[3])
            {
                case 1:
                    pic14.Image = picture1.Image;
                    break;
                case 2:
                    pic14.Image = picture2.Image;
                    break;
                case 3:
                    pic14.Image = picture3.Image;
                    break;
                case 4:
                    pic14.Image = picture4.Image;
                    break;
                case 5:
                    pic14.Image = picture5.Image;
                    break;
                case 6:
                    pic14.Image = picture6.Image;
                    break;
                case 7:
                    pic14.Image = picture7.Image;
                    break;
                case 8:
                    pic14.Image = picture8.Image;
                    break;
                default:
                    pic14.Image = picture9.Image;
                    break;
            }
            switch (_col1[4])
            {
                case 1:
                    pic15.Image = picture1.Image;
                    break;
                case 2:
                    pic15.Image = picture2.Image;
                    break;
                case 3:
                    pic15.Image = picture3.Image;
                    break;
                case 4:
                    pic15.Image = picture4.Image;
                    break;
                case 5:
                    pic15.Image = picture5.Image;
                    break;
                case 6:
                    pic15.Image = picture6.Image;
                    break;
                case 7:
                    pic15.Image = picture7.Image;
                    break;
                case 8:
                    pic15.Image = picture8.Image;
                    break;
                default:
                    pic15.Image = picture9.Image;
                    break;
            }
            switch (_col1[5])
            {
                case 1:
                    pic16.Image = picture1.Image;
                    break;
                case 2:
                    pic16.Image = picture2.Image;
                    break;
                case 3:
                    pic16.Image = picture3.Image;
                    break;
                case 4:
                    pic16.Image = picture4.Image;
                    break;
                case 5:
                    pic16.Image = picture5.Image;
                    break;
                case 6:
                    pic16.Image = picture6.Image;
                    break;
                case 7:
                    pic16.Image = picture7.Image;
                    break;
                case 8:
                    pic16.Image = picture8.Image;
                    break;
                default:
                    pic16.Image = picture9.Image;
                    break;
            }
            switch (_col1[6])
            {
                case 1:
                    pic17.Image = picture1.Image;
                    break;
                case 2:
                    pic17.Image = picture2.Image;
                    break;
                case 3:
                    pic17.Image = picture3.Image;
                    break;
                case 4:
                    pic17.Image = picture4.Image;
                    break;
                case 5:
                    pic17.Image = picture5.Image;
                    break;
                case 6:
                    pic17.Image = picture6.Image;
                    break;
                case 7:
                    pic17.Image = picture7.Image;
                    break;
                case 8:
                    pic17.Image = picture8.Image;
                    break;
                default:
                    pic17.Image = picture9.Image;
                    break;
            }
            switch (_col1[7])
            {
                case 1:
                    pic18.Image = picture1.Image;
                    break;
                case 2:
                    pic18.Image = picture2.Image;
                    break;
                case 3:
                    pic18.Image = picture3.Image;
                    break;
                case 4:
                    pic18.Image = picture4.Image;
                    break;
                case 5:
                    pic18.Image = picture5.Image;
                    break;
                case 6:
                    pic18.Image = picture6.Image;
                    break;
                case 7:
                    pic18.Image = picture7.Image;
                    break;
                case 8:
                    pic18.Image = picture8.Image;
                    break;
                default:
                    pic18.Image = picture9.Image;
                    break;
            }


            //col2 now

            switch (_col2[0])
            {
                case 1:
                    pic21.Image = picture1.Image;
                    break;
                case 2:
                    pic21.Image = picture2.Image;
                    break;
                case 3:
                    pic21.Image = picture3.Image;
                    break;
                case 4:
                    pic21.Image = picture4.Image;
                    break;
                case 5:
                    pic21.Image = picture5.Image;
                    break;
                case 6:
                    pic21.Image = picture6.Image;
                    break;
                case 7:
                    pic21.Image = picture7.Image;
                    break;
                case 8:
                    pic21.Image = picture8.Image;
                    break;
                default:
                    pic21.Image = picture9.Image;
                    break;
            }
            switch (_col2[1])
            {
                case 1:
                    pic22.Image = picture1.Image;
                    break;
                case 2:
                    pic22.Image = picture2.Image;
                    break;
                case 3:
                    pic22.Image = picture3.Image;
                    break;
                case 4:
                    pic22.Image = picture4.Image;
                    break;
                case 5:
                    pic22.Image = picture5.Image;
                    break;
                case 6:
                    pic22.Image = picture6.Image;
                    break;
                case 7:
                    pic22.Image = picture7.Image;
                    break;
                case 8:
                    pic22.Image = picture8.Image;
                    break;
                default:
                    pic22.Image = picture9.Image;
                    break;
            }
            switch (_col2[2])
            {
                case 1:
                    pic23.Image = picture1.Image;
                    break;
                case 2:
                    pic23.Image = picture2.Image;
                    break;
                case 3:
                    pic23.Image = picture3.Image;
                    break;
                case 4:
                    pic23.Image = picture4.Image;
                    break;
                case 5:
                    pic23.Image = picture5.Image;
                    break;
                case 6:
                    pic23.Image = picture6.Image;
                    break;
                case 7:
                    pic23.Image = picture7.Image;
                    break;
                case 8:
                    pic23.Image = picture8.Image;
                    break;
                default:
                    pic23.Image = picture9.Image;
                    break;
            }
            switch (_col2[3])
            {
                case 1:
                    pic24.Image = picture1.Image;
                    break;
                case 2:
                    pic24.Image = picture2.Image;
                    break;
                case 3:
                    pic24.Image = picture3.Image;
                    break;
                case 4:
                    pic24.Image = picture4.Image;
                    break;
                case 5:
                    pic24.Image = picture5.Image;
                    break;
                case 6:
                    pic24.Image = picture6.Image;
                    break;
                case 7:
                    pic24.Image = picture7.Image;
                    break;
                case 8:
                    pic24.Image = picture8.Image;
                    break;
                default:
                    pic24.Image = picture9.Image;
                    break;
            }
            switch (_col2[4])
            {
                case 1:
                    pic25.Image = picture1.Image;
                    break;
                case 2:
                    pic25.Image = picture2.Image;
                    break;
                case 3:
                    pic25.Image = picture3.Image;
                    break;
                case 4:
                    pic25.Image = picture4.Image;
                    break;
                case 5:
                    pic25.Image = picture5.Image;
                    break;
                case 6:
                    pic25.Image = picture6.Image;
                    break;
                case 7:
                    pic25.Image = picture7.Image;
                    break;
                case 8:
                    pic25.Image = picture8.Image;
                    break;
                default:
                    pic25.Image = picture9.Image;
                    break;
            }
            switch (_col2[5])
            {
                case 1:
                    pic26.Image = picture1.Image;
                    break;
                case 2:
                    pic26.Image = picture2.Image;
                    break;
                case 3:
                    pic26.Image = picture3.Image;
                    break;
                case 4:
                    pic26.Image = picture4.Image;
                    break;
                case 5:
                    pic26.Image = picture5.Image;
                    break;
                case 6:
                    pic26.Image = picture6.Image;
                    break;
                case 7:
                    pic26.Image = picture7.Image;
                    break;
                case 8:
                    pic26.Image = picture8.Image;
                    break;
                default:
                    pic26.Image = picture9.Image;
                    break;
            }
            switch (_col2[6])
            {
                case 1:
                    pic27.Image = picture1.Image;
                    break;
                case 2:
                    pic27.Image = picture2.Image;
                    break;
                case 3:
                    pic27.Image = picture3.Image;
                    break;
                case 4:
                    pic27.Image = picture4.Image;
                    break;
                case 5:
                    pic27.Image = picture5.Image;
                    break;
                case 6:
                    pic27.Image = picture6.Image;
                    break;
                case 7:
                    pic27.Image = picture7.Image;
                    break;
                case 8:
                    pic27.Image = picture8.Image;
                    break;
                default:
                    pic27.Image = picture9.Image;
                    break;
            }
            switch (_col2[7])
            {
                case 1:
                    pic28.Image = picture1.Image;
                    break;
                case 2:
                    pic28.Image = picture2.Image;
                    break;
                case 3:
                    pic28.Image = picture3.Image;
                    break;
                case 4:
                    pic28.Image = picture4.Image;
                    break;
                case 5:
                    pic28.Image = picture5.Image;
                    break;
                case 6:
                    pic28.Image = picture6.Image;
                    break;
                case 7:
                    pic28.Image = picture7.Image;
                    break;
                case 8:
                    pic28.Image = picture8.Image;
                    break;
                default:
                    pic28.Image = picture9.Image;
                    break;
            }

            //col3 now

            switch (_col3[0])
            {
                case 1:
                    pic31.Image = picture1.Image;
                    break;
                case 2:
                    pic31.Image = picture2.Image;
                    break;
                case 3:
                    pic31.Image = picture3.Image;
                    break;
                case 4:
                    pic31.Image = picture4.Image;
                    break;
                case 5:
                    pic31.Image = picture5.Image;
                    break;
                case 6:
                    pic31.Image = picture6.Image;
                    break;
                case 7:
                    pic31.Image = picture7.Image;
                    break;
                case 8:
                    pic31.Image = picture8.Image;
                    break;
                default:
                    pic31.Image = picture9.Image;
                    break;
            }
            switch (_col3[1])
            {
                case 1:
                    pic32.Image = picture1.Image;
                    break;
                case 2:
                    pic32.Image = picture2.Image;
                    break;
                case 3:
                    pic32.Image = picture3.Image;
                    break;
                case 4:
                    pic32.Image = picture4.Image;
                    break;
                case 5:
                    pic32.Image = picture5.Image;
                    break;
                case 6:
                    pic32.Image = picture6.Image;
                    break;
                case 7:
                    pic32.Image = picture7.Image;
                    break;
                case 8:
                    pic32.Image = picture8.Image;
                    break;
                default:
                    pic32.Image = picture9.Image;
                    break;
            }
            switch (_col3[2])
            {
                case 1:
                    pic33.Image = picture1.Image;
                    break;
                case 2:
                    pic33.Image = picture2.Image;
                    break;
                case 3:
                    pic33.Image = picture3.Image;
                    break;
                case 4:
                    pic33.Image = picture4.Image;
                    break;
                case 5:
                    pic33.Image = picture5.Image;
                    break;
                case 6:
                    pic33.Image = picture6.Image;
                    break;
                case 7:
                    pic33.Image = picture7.Image;
                    break;
                case 8:
                    pic33.Image = picture8.Image;
                    break;
                default:
                    pic33.Image = picture9.Image;
                    break;
            }
            switch (_col3[3])
            {
                case 1:
                    pic34.Image = picture1.Image;
                    break;
                case 2:
                    pic34.Image = picture2.Image;
                    break;
                case 3:
                    pic34.Image = picture3.Image;
                    break;
                case 4:
                    pic34.Image = picture4.Image;
                    break;
                case 5:
                    pic34.Image = picture5.Image;
                    break;
                case 6:
                    pic34.Image = picture6.Image;
                    break;
                case 7:
                    pic34.Image = picture7.Image;
                    break;
                case 8:
                    pic34.Image = picture8.Image;
                    break;
                default:
                    pic34.Image = picture9.Image;
                    break;
            }
            switch (_col3[4])
            {
                case 1:
                    pic35.Image = picture1.Image;
                    break;
                case 2:
                    pic35.Image = picture2.Image;
                    break;
                case 3:
                    pic35.Image = picture3.Image;
                    break;
                case 4:
                    pic35.Image = picture4.Image;
                    break;
                case 5:
                    pic35.Image = picture5.Image;
                    break;
                case 6:
                    pic35.Image = picture6.Image;
                    break;
                case 7:
                    pic35.Image = picture7.Image;
                    break;
                case 8:
                    pic35.Image = picture8.Image;
                    break;
                default:
                    pic35.Image = picture9.Image;
                    break;
            }
            switch (_col3[5])
            {
                case 1:
                    pic36.Image = picture1.Image;
                    break;
                case 2:
                    pic36.Image = picture2.Image;
                    break;
                case 3:
                    pic36.Image = picture3.Image;
                    break;
                case 4:
                    pic36.Image = picture4.Image;
                    break;
                case 5:
                    pic36.Image = picture5.Image;
                    break;
                case 6:
                    pic36.Image = picture6.Image;
                    break;
                case 7:
                    pic36.Image = picture7.Image;
                    break;
                case 8:
                    pic36.Image = picture8.Image;
                    break;
                default:
                    pic36.Image = picture9.Image;
                    break;
            }
            switch (_col3[6])
            {
                case 1:
                    pic37.Image = picture1.Image;
                    break;
                case 2:
                    pic37.Image = picture2.Image;
                    break;
                case 3:
                    pic37.Image = picture3.Image;
                    break;
                case 4:
                    pic37.Image = picture4.Image;
                    break;
                case 5:
                    pic37.Image = picture5.Image;
                    break;
                case 6:
                    pic37.Image = picture6.Image;
                    break;
                case 7:
                    pic37.Image = picture7.Image;
                    break;
                case 8:
                    pic37.Image = picture8.Image;
                    break;
                default:
                    pic37.Image = picture9.Image;
                    break;
            }
            switch (_col3[7])
            {
                case 1:
                    pic38.Image = picture1.Image;
                    break;
                case 2:
                    pic38.Image = picture2.Image;
                    break;
                case 3:
                    pic38.Image = picture3.Image;
                    break;
                case 4:
                    pic38.Image = picture4.Image;
                    break;
                case 5:
                    pic38.Image = picture5.Image;
                    break;
                case 6:
                    pic38.Image = picture6.Image;
                    break;
                case 7:
                    pic38.Image = picture7.Image;
                    break;
                case 8:
                    pic38.Image = picture8.Image;
                    break;
                default:
                    pic38.Image = picture9.Image;
                    break;
            }

            //col4 now

            switch (_col4[0])
            {
                case 1:
                    pic41.Image = picture1.Image;
                    break;
                case 2:
                    pic41.Image = picture2.Image;
                    break;
                case 3:
                    pic41.Image = picture3.Image;
                    break;
                case 4:
                    pic41.Image = picture4.Image;
                    break;
                case 5:
                    pic41.Image = picture5.Image;
                    break;
                case 6:
                    pic41.Image = picture6.Image;
                    break;
                case 7:
                    pic41.Image = picture7.Image;
                    break;
                case 8:
                    pic41.Image = picture8.Image;
                    break;
                default:
                    pic41.Image = picture9.Image;
                    break;
            }
            switch (_col4[1])
            {
                case 1:
                    pic42.Image = picture1.Image;
                    break;
                case 2:
                    pic42.Image = picture2.Image;
                    break;
                case 3:
                    pic42.Image = picture3.Image;
                    break;
                case 4:
                    pic42.Image = picture4.Image;
                    break;
                case 5:
                    pic42.Image = picture5.Image;
                    break;
                case 6:
                    pic42.Image = picture6.Image;
                    break;
                case 7:
                    pic42.Image = picture7.Image;
                    break;
                case 8:
                    pic42.Image = picture8.Image;
                    break;
                default:
                    pic42.Image = picture9.Image;
                    break;
            }
            switch (_col4[2])
            {
                case 1:
                    pic43.Image = picture1.Image;
                    break;
                case 2:
                    pic43.Image = picture2.Image;
                    break;
                case 3:
                    pic43.Image = picture3.Image;
                    break;
                case 4:
                    pic43.Image = picture4.Image;
                    break;
                case 5:
                    pic43.Image = picture5.Image;
                    break;
                case 6:
                    pic43.Image = picture6.Image;
                    break;
                case 7:
                    pic43.Image = picture7.Image;
                    break;
                case 8:
                    pic43.Image = picture8.Image;
                    break;
                default:
                    pic43.Image = picture9.Image;
                    break;
            }
            switch (_col4[3])
            {
                case 1:
                    pic44.Image = picture1.Image;
                    break;
                case 2:
                    pic44.Image = picture2.Image;
                    break;
                case 3:
                    pic44.Image = picture3.Image;
                    break;
                case 4:
                    pic44.Image = picture4.Image;
                    break;
                case 5:
                    pic44.Image = picture5.Image;
                    break;
                case 6:
                    pic44.Image = picture6.Image;
                    break;
                case 7:
                    pic44.Image = picture7.Image;
                    break;
                case 8:
                    pic44.Image = picture8.Image;
                    break;
                default:
                    pic44.Image = picture9.Image;
                    break;
            }
            switch (_col4[4])
            {
                case 1:
                    pic45.Image = picture1.Image;
                    break;
                case 2:
                    pic45.Image = picture2.Image;
                    break;
                case 3:
                    pic45.Image = picture3.Image;
                    break;
                case 4:
                    pic45.Image = picture4.Image;
                    break;
                case 5:
                    pic45.Image = picture5.Image;
                    break;
                case 6:
                    pic45.Image = picture6.Image;
                    break;
                case 7:
                    pic45.Image = picture7.Image;
                    break;
                case 8:
                    pic45.Image = picture8.Image;
                    break;
                default:
                    pic45.Image = picture9.Image;
                    break;
            }
            switch (_col4[5])
            {
                case 1:
                    pic46.Image = picture1.Image;
                    break;
                case 2:
                    pic46.Image = picture2.Image;
                    break;
                case 3:
                    pic46.Image = picture3.Image;
                    break;
                case 4:
                    pic46.Image = picture4.Image;
                    break;
                case 5:
                    pic46.Image = picture5.Image;
                    break;
                case 6:
                    pic46.Image = picture6.Image;
                    break;
                case 7:
                    pic46.Image = picture7.Image;
                    break;
                case 8:
                    pic46.Image = picture8.Image;
                    break;
                default:
                    pic46.Image = picture9.Image;
                    break;
            }
            switch (_col4[6])
            {
                case 1:
                    pic47.Image = picture1.Image;
                    break;
                case 2:
                    pic47.Image = picture2.Image;
                    break;
                case 3:
                    pic47.Image = picture3.Image;
                    break;
                case 4:
                    pic47.Image = picture4.Image;
                    break;
                case 5:
                    pic47.Image = picture5.Image;
                    break;
                case 6:
                    pic47.Image = picture6.Image;
                    break;
                case 7:
                    pic47.Image = picture7.Image;
                    break;
                case 8:
                    pic47.Image = picture8.Image;
                    break;
                default:
                    pic47.Image = picture9.Image;
                    break;
            }
            switch (_col4[7])
            {
                case 1:
                    pic48.Image = picture1.Image;
                    break;
                case 2:
                    pic48.Image = picture2.Image;
                    break;
                case 3:
                    pic48.Image = picture3.Image;
                    break;
                case 4:
                    pic48.Image = picture4.Image;
                    break;
                case 5:
                    pic48.Image = picture5.Image;
                    break;
                case 6:
                    pic48.Image = picture6.Image;
                    break;
                case 7:
                    pic48.Image = picture7.Image;
                    break;
                case 8:
                    pic48.Image = picture8.Image;
                    break;
                default:
                    pic48.Image = picture9.Image;
                    break;
            }

            //col5 now

            switch (_col5[0])
            {
                case 1:
                    pic51.Image = picture1.Image;
                    break;
                case 2:
                    pic51.Image = picture2.Image;
                    break;
                case 3:
                    pic51.Image = picture3.Image;
                    break;
                case 4:
                    pic51.Image = picture4.Image;
                    break;
                case 5:
                    pic51.Image = picture5.Image;
                    break;
                case 6:
                    pic51.Image = picture6.Image;
                    break;
                case 7:
                    pic51.Image = picture7.Image;
                    break;
                case 8:
                    pic51.Image = picture8.Image;
                    break;
                default:
                    pic51.Image = picture9.Image;
                    break;
            }
            switch (_col5[1])
            {
                case 1:
                    pic52.Image = picture1.Image;
                    break;
                case 2:
                    pic52.Image = picture2.Image;
                    break;
                case 3:
                    pic52.Image = picture3.Image;
                    break;
                case 4:
                    pic52.Image = picture4.Image;
                    break;
                case 5:
                    pic52.Image = picture5.Image;
                    break;
                case 6:
                    pic52.Image = picture6.Image;
                    break;
                case 7:
                    pic52.Image = picture7.Image;
                    break;
                case 8:
                    pic52.Image = picture8.Image;
                    break;
                default:
                    pic52.Image = picture9.Image;
                    break;
            }
            switch (_col5[2])
            {
                case 1:
                    pic53.Image = picture1.Image;
                    break;
                case 2:
                    pic53.Image = picture2.Image;
                    break;
                case 3:
                    pic53.Image = picture3.Image;
                    break;
                case 4:
                    pic53.Image = picture4.Image;
                    break;
                case 5:
                    pic53.Image = picture5.Image;
                    break;
                case 6:
                    pic53.Image = picture6.Image;
                    break;
                case 7:
                    pic53.Image = picture7.Image;
                    break;
                case 8:
                    pic53.Image = picture8.Image;
                    break;
                default:
                    pic53.Image = picture9.Image;
                    break;
            }
            switch (_col5[3])
            {
                case 1:
                    pic54.Image = picture1.Image;
                    break;
                case 2:
                    pic54.Image = picture2.Image;
                    break;
                case 3:
                    pic54.Image = picture3.Image;
                    break;
                case 4:
                    pic54.Image = picture4.Image;
                    break;
                case 5:
                    pic54.Image = picture5.Image;
                    break;
                case 6:
                    pic54.Image = picture6.Image;
                    break;
                case 7:
                    pic54.Image = picture7.Image;
                    break;
                case 8:
                    pic54.Image = picture8.Image;
                    break;
                default:
                    pic54.Image = picture9.Image;
                    break;
            }
            switch (_col5[4])
            {
                case 1:
                    pic55.Image = picture1.Image;
                    break;
                case 2:
                    pic55.Image = picture2.Image;
                    break;
                case 3:
                    pic55.Image = picture3.Image;
                    break;
                case 4:
                    pic55.Image = picture4.Image;
                    break;
                case 5:
                    pic55.Image = picture5.Image;
                    break;
                case 6:
                    pic55.Image = picture6.Image;
                    break;
                case 7:
                    pic55.Image = picture7.Image;
                    break;
                case 8:
                    pic55.Image = picture8.Image;
                    break;
                default:
                    pic55.Image = picture9.Image;
                    break;
            }
            switch (_col5[5])
            {
                case 1:
                    pic56.Image = picture1.Image;
                    break;
                case 2:
                    pic56.Image = picture2.Image;
                    break;
                case 3:
                    pic56.Image = picture3.Image;
                    break;
                case 4:
                    pic56.Image = picture4.Image;
                    break;
                case 5:
                    pic56.Image = picture5.Image;
                    break;
                case 6:
                    pic56.Image = picture6.Image;
                    break;
                case 7:
                    pic56.Image = picture7.Image;
                    break;
                case 8:
                    pic56.Image = picture8.Image;
                    break;
                default:
                    pic56.Image = picture9.Image;
                    break;
            }
            switch (_col5[6])
            {
                case 1:
                    pic57.Image = picture1.Image;
                    break;
                case 2:
                    pic57.Image = picture2.Image;
                    break;
                case 3:
                    pic57.Image = picture3.Image;
                    break;
                case 4:
                    pic57.Image = picture4.Image;
                    break;
                case 5:
                    pic57.Image = picture5.Image;
                    break;
                case 6:
                    pic57.Image = picture6.Image;
                    break;
                case 7:
                    pic57.Image = picture7.Image;
                    break;
                case 8:
                    pic57.Image = picture8.Image;
                    break;
                default:
                    pic57.Image = picture9.Image;
                    break;
            }
            switch (_col5[7])
            {
                case 1:
                    pic58.Image = picture1.Image;
                    break;
                case 2:
                    pic58.Image = picture2.Image;
                    break;
                case 3:
                    pic58.Image = picture3.Image;
                    break;
                case 4:
                    pic58.Image = picture4.Image;
                    break;
                case 5:
                    pic58.Image = picture5.Image;
                    break;
                case 6:
                    pic58.Image = picture6.Image;
                    break;
                case 7:
                    pic58.Image = picture7.Image;
                    break;
                case 8:
                    pic58.Image = picture8.Image;
                    break;
                default:
                    pic58.Image = picture9.Image;
                    break;
            }

            //col6 now

            switch (_col6[0])
            {
                case 1:
                    pic61.Image = picture1.Image;
                    break;
                case 2:
                    pic61.Image = picture2.Image;
                    break;
                case 3:
                    pic61.Image = picture3.Image;
                    break;
                case 4:
                    pic61.Image = picture4.Image;
                    break;
                case 5:
                    pic61.Image = picture5.Image;
                    break;
                case 6:
                    pic61.Image = picture6.Image;
                    break;
                case 7:
                    pic61.Image = picture7.Image;
                    break;
                case 8:
                    pic61.Image = picture8.Image;
                    break;
                default:
                    pic61.Image = picture9.Image;
                    break;
            }
            switch (_col6[1])
            {
                case 1:
                    pic62.Image = picture1.Image;
                    break;
                case 2:
                    pic62.Image = picture2.Image;
                    break;
                case 3:
                    pic62.Image = picture3.Image;
                    break;
                case 4:
                    pic62.Image = picture4.Image;
                    break;
                case 5:
                    pic62.Image = picture5.Image;
                    break;
                case 6:
                    pic62.Image = picture6.Image;
                    break;
                case 7:
                    pic62.Image = picture7.Image;
                    break;
                case 8:
                    pic62.Image = picture8.Image;
                    break;
                default:
                    pic62.Image = picture9.Image;
                    break;
            }
            switch (_col6[2])
            {
                case 1:
                    pic63.Image = picture1.Image;
                    break;
                case 2:
                    pic63.Image = picture2.Image;
                    break;
                case 3:
                    pic63.Image = picture3.Image;
                    break;
                case 4:
                    pic63.Image = picture4.Image;
                    break;
                case 5:
                    pic63.Image = picture5.Image;
                    break;
                case 6:
                    pic63.Image = picture6.Image;
                    break;
                case 7:
                    pic63.Image = picture7.Image;
                    break;
                case 8:
                    pic63.Image = picture8.Image;
                    break;
                default:
                    pic63.Image = picture9.Image;
                    break;
            }
            switch (_col6[3])
            {
                case 1:
                    pic64.Image = picture1.Image;
                    break;
                case 2:
                    pic64.Image = picture2.Image;
                    break;
                case 3:
                    pic64.Image = picture3.Image;
                    break;
                case 4:
                    pic64.Image = picture4.Image;
                    break;
                case 5:
                    pic64.Image = picture5.Image;
                    break;
                case 6:
                    pic64.Image = picture6.Image;
                    break;
                case 7:
                    pic64.Image = picture7.Image;
                    break;
                case 8:
                    pic64.Image = picture8.Image;
                    break;
                default:
                    pic64.Image = picture9.Image;
                    break;
            }
            switch (_col6[4])
            {
                case 1:
                    pic65.Image = picture1.Image;
                    break;
                case 2:
                    pic65.Image = picture2.Image;
                    break;
                case 3:
                    pic65.Image = picture3.Image;
                    break;
                case 4:
                    pic65.Image = picture4.Image;
                    break;
                case 5:
                    pic65.Image = picture5.Image;
                    break;
                case 6:
                    pic65.Image = picture6.Image;
                    break;
                case 7:
                    pic65.Image = picture7.Image;
                    break;
                case 8:
                    pic65.Image = picture8.Image;
                    break;
                default:
                    pic65.Image = picture9.Image;
                    break;
            }
            switch (_col6[5])
            {
                case 1:
                    pic66.Image = picture1.Image;
                    break;
                case 2:
                    pic66.Image = picture2.Image;
                    break;
                case 3:
                    pic66.Image = picture3.Image;
                    break;
                case 4:
                    pic66.Image = picture4.Image;
                    break;
                case 5:
                    pic66.Image = picture5.Image;
                    break;
                case 6:
                    pic66.Image = picture6.Image;
                    break;
                case 7:
                    pic66.Image = picture7.Image;
                    break;
                case 8:
                    pic66.Image = picture8.Image;
                    break;
                default:
                    pic66.Image = picture9.Image;
                    break;
            }
            switch (_col6[6])
            {
                case 1:
                    pic67.Image = picture1.Image;
                    break;
                case 2:
                    pic67.Image = picture2.Image;
                    break;
                case 3:
                    pic67.Image = picture3.Image;
                    break;
                case 4:
                    pic67.Image = picture4.Image;
                    break;
                case 5:
                    pic67.Image = picture5.Image;
                    break;
                case 6:
                    pic67.Image = picture6.Image;
                    break;
                case 7:
                    pic67.Image = picture7.Image;
                    break;
                case 8:
                    pic67.Image = picture8.Image;
                    break;
                default:
                    pic67.Image = picture9.Image;
                    break;
            }
            switch (_col6[7])
            {
                case 1:
                    pic68.Image = picture1.Image;
                    break;
                case 2:
                    pic68.Image = picture2.Image;
                    break;
                case 3:
                    pic68.Image = picture3.Image;
                    break;
                case 4:
                    pic68.Image = picture4.Image;
                    break;
                case 5:
                    pic68.Image = picture5.Image;
                    break;
                case 6:
                    pic68.Image = picture6.Image;
                    break;
                case 7:
                    pic68.Image = picture7.Image;
                    break;
                case 8:
                    pic68.Image = picture8.Image;
                    break;
                default:
                    pic68.Image = picture9.Image;
                    break;
            }

            //col7 now

            switch (_col7[0])
            {
                case 1:
                    pic71.Image = picture1.Image;
                    break;
                case 2:
                    pic71.Image = picture2.Image;
                    break;
                case 3:
                    pic71.Image = picture3.Image;
                    break;
                case 4:
                    pic71.Image = picture4.Image;
                    break;
                case 5:
                    pic71.Image = picture5.Image;
                    break;
                case 6:
                    pic71.Image = picture6.Image;
                    break;
                case 7:
                    pic71.Image = picture7.Image;
                    break;
                case 8:
                    pic71.Image = picture8.Image;
                    break;
                default:
                    pic71.Image = picture9.Image;
                    break;
            }
            switch (_col7[1])
            {
                case 1:
                    pic72.Image = picture1.Image;
                    break;
                case 2:
                    pic72.Image = picture2.Image;
                    break;
                case 3:
                    pic72.Image = picture3.Image;
                    break;
                case 4:
                    pic72.Image = picture4.Image;
                    break;
                case 5:
                    pic72.Image = picture5.Image;
                    break;
                case 6:
                    pic72.Image = picture6.Image;
                    break;
                case 7:
                    pic72.Image = picture7.Image;
                    break;
                case 8:
                    pic72.Image = picture8.Image;
                    break;
                default:
                    pic72.Image = picture9.Image;
                    break;
            }
            switch (_col7[2])
            {
                case 1:
                    pic73.Image = picture1.Image;
                    break;
                case 2:
                    pic73.Image = picture2.Image;
                    break;
                case 3:
                    pic73.Image = picture3.Image;
                    break;
                case 4:
                    pic73.Image = picture4.Image;
                    break;
                case 5:
                    pic73.Image = picture5.Image;
                    break;
                case 6:
                    pic73.Image = picture6.Image;
                    break;
                case 7:
                    pic73.Image = picture7.Image;
                    break;
                case 8:
                    pic73.Image = picture8.Image;
                    break;
                default:
                    pic73.Image = picture9.Image;
                    break;
            }
            switch (_col7[3])
            {
                case 1:
                    pic74.Image = picture1.Image;
                    break;
                case 2:
                    pic74.Image = picture2.Image;
                    break;
                case 3:
                    pic74.Image = picture3.Image;
                    break;
                case 4:
                    pic74.Image = picture4.Image;
                    break;
                case 5:
                    pic74.Image = picture5.Image;
                    break;
                case 6:
                    pic74.Image = picture6.Image;
                    break;
                case 7:
                    pic74.Image = picture7.Image;
                    break;
                case 8:
                    pic74.Image = picture8.Image;
                    break;
                default:
                    pic74.Image = picture9.Image;
                    break;
            }
            switch (_col7[4])
            {
                case 1:
                    pic75.Image = picture1.Image;
                    break;
                case 2:
                    pic75.Image = picture2.Image;
                    break;
                case 3:
                    pic75.Image = picture3.Image;
                    break;
                case 4:
                    pic75.Image = picture4.Image;
                    break;
                case 5:
                    pic75.Image = picture5.Image;
                    break;
                case 6:
                    pic75.Image = picture6.Image;
                    break;
                case 7:
                    pic75.Image = picture7.Image;
                    break;
                case 8:
                    pic75.Image = picture8.Image;
                    break;
                default:
                    pic75.Image = picture9.Image;
                    break;
            }
            switch (_col7[5])
            {
                case 1:
                    pic76.Image = picture1.Image;
                    break;
                case 2:
                    pic76.Image = picture2.Image;
                    break;
                case 3:
                    pic76.Image = picture3.Image;
                    break;
                case 4:
                    pic76.Image = picture4.Image;
                    break;
                case 5:
                    pic76.Image = picture5.Image;
                    break;
                case 6:
                    pic76.Image = picture6.Image;
                    break;
                case 7:
                    pic76.Image = picture7.Image;
                    break;
                case 8:
                    pic76.Image = picture8.Image;
                    break;
                default:
                    pic76.Image = picture9.Image;
                    break;
            }
            switch (_col7[6])
            {
                case 1:
                    pic77.Image = picture1.Image;
                    break;
                case 2:
                    pic77.Image = picture2.Image;
                    break;
                case 3:
                    pic77.Image = picture3.Image;
                    break;
                case 4:
                    pic77.Image = picture4.Image;
                    break;
                case 5:
                    pic77.Image = picture5.Image;
                    break;
                case 6:
                    pic77.Image = picture6.Image;
                    break;
                case 7:
                    pic77.Image = picture7.Image;
                    break;
                case 8:
                    pic77.Image = picture8.Image;
                    break;
                default:
                    pic77.Image = picture9.Image;
                    break;
            }
            switch (_col7[7])
            {
                case 1:
                    pic78.Image = picture1.Image;
                    break;
                case 2:
                    pic78.Image = picture2.Image;
                    break;
                case 3:
                    pic78.Image = picture3.Image;
                    break;
                case 4:
                    pic78.Image = picture4.Image;
                    break;
                case 5:
                    pic78.Image = picture5.Image;
                    break;
                case 6:
                    pic78.Image = picture6.Image;
                    break;
                case 7:
                    pic78.Image = picture7.Image;
                    break;
                case 8:
                    pic78.Image = picture8.Image;
                    break;
                default:
                    pic78.Image = picture9.Image;
                    break;
            }

            //col8 now

            switch (_col8[0])
            {
                case 1:
                    pic81.Image = picture1.Image;
                    break;
                case 2:
                    pic81.Image = picture2.Image;
                    break;
                case 3:
                    pic81.Image = picture3.Image;
                    break;
                case 4:
                    pic81.Image = picture4.Image;
                    break;
                case 5:
                    pic81.Image = picture5.Image;
                    break;
                case 6:
                    pic81.Image = picture6.Image;
                    break;
                case 7:
                    pic81.Image = picture7.Image;
                    break;
                case 8:
                    pic81.Image = picture8.Image;
                    break;
                default:
                    pic81.Image = picture9.Image;
                    break;
            }
            switch (_col8[1])
            {
                case 1:
                    pic82.Image = picture1.Image;
                    break;
                case 2:
                    pic82.Image = picture2.Image;
                    break;
                case 3:
                    pic82.Image = picture3.Image;
                    break;
                case 4:
                    pic82.Image = picture4.Image;
                    break;
                case 5:
                    pic82.Image = picture5.Image;
                    break;
                case 6:
                    pic82.Image = picture6.Image;
                    break;
                case 7:
                    pic82.Image = picture7.Image;
                    break;
                case 8:
                    pic82.Image = picture8.Image;
                    break;
                default:
                    pic82.Image = picture9.Image;
                    break;
            }
            switch (_col8[2])
            {
                case 1:
                    pic83.Image = picture1.Image;
                    break;
                case 2:
                    pic83.Image = picture2.Image;
                    break;
                case 3:
                    pic83.Image = picture3.Image;
                    break;
                case 4:
                    pic83.Image = picture4.Image;
                    break;
                case 5:
                    pic83.Image = picture5.Image;
                    break;
                case 6:
                    pic83.Image = picture6.Image;
                    break;
                case 7:
                    pic83.Image = picture7.Image;
                    break;
                case 8:
                    pic83.Image = picture8.Image;
                    break;
                default:
                    pic83.Image = picture9.Image;
                    break;
            }
            switch (_col8[3])
            {
                case 1:
                    pic84.Image = picture1.Image;
                    break;
                case 2:
                    pic84.Image = picture2.Image;
                    break;
                case 3:
                    pic84.Image = picture3.Image;
                    break;
                case 4:
                    pic84.Image = picture4.Image;
                    break;
                case 5:
                    pic84.Image = picture5.Image;
                    break;
                case 6:
                    pic84.Image = picture6.Image;
                    break;
                case 7:
                    pic84.Image = picture7.Image;
                    break;
                case 8:
                    pic84.Image = picture8.Image;
                    break;
                default:
                    pic84.Image = picture9.Image;
                    break;
            }
            switch (_col8[4])
            {
                case 1:
                    pic85.Image = picture1.Image;
                    break;
                case 2:
                    pic85.Image = picture2.Image;
                    break;
                case 3:
                    pic85.Image = picture3.Image;
                    break;
                case 4:
                    pic85.Image = picture4.Image;
                    break;
                case 5:
                    pic85.Image = picture5.Image;
                    break;
                case 6:
                    pic85.Image = picture6.Image;
                    break;
                case 7:
                    pic85.Image = picture7.Image;
                    break;
                case 8:
                    pic85.Image = picture8.Image;
                    break;
                default:
                    pic85.Image = picture9.Image;
                    break;
            }
            switch (_col8[5])
            {
                case 1:
                    pic86.Image = picture1.Image;
                    break;
                case 2:
                    pic86.Image = picture2.Image;
                    break;
                case 3:
                    pic86.Image = picture3.Image;
                    break;
                case 4:
                    pic86.Image = picture4.Image;
                    break;
                case 5:
                    pic86.Image = picture5.Image;
                    break;
                case 6:
                    pic86.Image = picture6.Image;
                    break;
                case 7:
                    pic86.Image = picture7.Image;
                    break;
                case 8:
                    pic86.Image = picture8.Image;
                    break;
                default:
                    pic86.Image = picture9.Image;
                    break;
            }
            switch (_col8[6])
            {
                case 1:
                    pic87.Image = picture1.Image;
                    break;
                case 2:
                    pic87.Image = picture2.Image;
                    break;
                case 3:
                    pic87.Image = picture3.Image;
                    break;
                case 4:
                    pic87.Image = picture4.Image;
                    break;
                case 5:
                    pic87.Image = picture5.Image;
                    break;
                case 6:
                    pic87.Image = picture6.Image;
                    break;
                case 7:
                    pic87.Image = picture7.Image;
                    break;
                case 8:
                    pic87.Image = picture8.Image;
                    break;
                default:
                    pic87.Image = picture9.Image;
                    break;
            }
            switch (_col8[7])
            {
                case 1:
                    pic88.Image = picture1.Image;
                    break;
                case 2:
                    pic88.Image = picture2.Image;
                    break;
                case 3:
                    pic88.Image = picture3.Image;
                    break;
                case 4:
                    pic88.Image = picture4.Image;
                    break;
                case 5:
                    pic88.Image = picture5.Image;
                    break;
                case 6:
                    pic88.Image = picture6.Image;
                    break;
                case 7:
                    pic88.Image = picture7.Image;
                    break;
                case 8:
                    pic88.Image = picture8.Image;
                    break;
                default:
                    pic88.Image = picture9.Image;
                    break;
            }


        }

        private bool fMiss()
        {
            Random rnd1 = new Random();

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void fPNext()
        {
            Random rnd1 = new Random();
            bool bFound = false;
            int nCol=0, nRow=0, nPlayer;

            mbPlayer = true;
            mbUsearrow = false;

            nPlayer = fPlayer(mnCol, mnRow);
            if (nPlayer == -1)
            {

            }
            else
            {
                fHighlightOff(mnCol, mnRow);
            }
                
            do
            {
                mnPlayer = rnd1.Next(1, mnPlayers + 1);
                if (_playercol[mnPlayer - 1] > 0)
                {
                    if (_playerrow[mnPlayer - 1] > 0)
                    {
                        if (_playerHP[mnPlayer - 1] > 0)
                        {
                            bFound = true;
                        }
                    }
                }
            } while (bFound == false);

            if (bFound == false)
            {
                mbPlayer = false;
                mnMovesleft = 0;
                lblMovesleft.Text = "MOVESLEFT = 0";
                MessageBox.Show("You lost", "GameEnded");
            }
            else
            {
                mnCol = _playercol[mnPlayer - 1];
                mnRow = _playerrow[mnPlayer - 1];
                nPlayer = fPlayer(mnCol, mnRow);
                if (nPlayer == -1)
                {

                }
                else
                {
                    fHighlightOn(mnCol, mnRow);
                }
                lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

                if (nPlayer > 0)
                {
                    lblSelected.Text = lblSelected.Text + " (Player" + Convert.ToString(nPlayer) + ")";
                    mnSavecol = mnCol;
                    mnSaverow = mnRow;
                    fraPlayer.Text = "Player" + Convert.ToString(nPlayer);
                    fraPlayer.Visible = true;
                    lblVoid1.Text = "HP = " + Convert.ToString(_playerHP[nPlayer - 1]);
                    lblVoid2.Text = "SP = " + Convert.ToString(_playerSP[nPlayer - 1]);
                   lblVoid3.Text = "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    mnSavecol = mnCol;
                    mnSaverow = mnRow;
                }
                else
                {
                    fraPlayer.Visible = false;
                }
                mbPlayer = true;
                mnMovesleft = 9;
                lblMovesleft.Text = "MOVESLEFT = 9";
            }
        }
       private void fKill(int nCol, int nRow)
        {
            switch (nCol)
            {
                case 1:
                    _col1[nRow-1] = 4;
                    break;
                case 2:
                    _col2[nRow-1] = 4;
                    break;
                case 3:
                    _col3[nRow-1] = 4;
                    break;
                case 4:
                    _col4[nRow-1] = 4;
                    break;
                case 5:
                    _col5[nRow-1] = 4;
                    break;
                case 6:
                    _col6[nRow-1] = 4;
                    break;
                case 7:
                    _col7[nRow-1] = 4;
                    break;
                default:
                    _col8[nRow-1] = 4;
                    break;
            }
            mnKillCol = nCol;
            mnKillRow = nRow;
            fUpdateDisplay();
            tmrKill.Enabled = true;
        }
        private void fHPSet(int nCol,int nRow, int nHP)
        {
            switch (nCol)
            {
                case 1:
                    _HP1[nRow - 1] = nHP;
                    break;
                case 2:
                    _HP2[nRow - 1] = nHP;
                    break;
                case 3:
                    _HP3[nRow - 1] = nHP;
                    break;
                case 4:
                    _HP4[nRow - 1] = nHP;
                    break;
                case 5:
                    _HP5[nRow - 1] = nHP;
                    break;
                case 6:
                    _HP6[nRow - 1] = nHP;
                    break;
                case 7:
                    _HP7[nRow - 1] = nHP;
                    break;
                default:
                    _HP8[nRow - 1] = nHP;
                    break;
            }
        }

        private int fHP(int nCol, int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _HP1[nRow - 1];
                case 2:
                    return _HP2[nRow - 1];
                case 3:
                    return _HP3[nRow - 1];
                case 4:
                    return _HP4[nRow - 1];
                  case 5:
                    return _HP5[nRow - 1];
                  case 6:
                    return _HP6[nRow - 1];
                   case 7:
                    return _HP7[nRow - 1];
                 default:
                    return _HP8[nRow - 1];
                
            }
        }

       private int fPlayer(int nCol, int nRow)
        {
            int nType = 0;
      
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                default:
                    nType = _col8[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    for (int i = 1; i <= mnPlayers; i++)
                    {
                        if (_playercol[i - 1] == nCol)
                        {
                            if (_playerrow[i - 1] == nRow)
                            {
                                return i;
                            }
                        }
                    }
                    break;
                case 7:
                    for (int i = 1; i <= mnPlayers; i++)
                    {
                        if (_playercol[i - 1] == nCol)
                        {
                            if (_playerrow[i - 1] == nRow)
                            {
                                return i;
                            }
                        }
                    }
                    break;
                case 8:
                    for (int i = 1; i <= mnPlayers; i++)
                    {
                        if (_playercol[i - 1] == nCol)
                        {
                            if (_playerrow[i - 1] == nRow)
                            {
                                return i;
                            }
                        }
                    }
                    break;
                default:

                    break;
            }
            return -1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            tmrKill.Enabled = false;
            fReset();
            fUpdateDisplay();
            fPNext();

        }

        private void pic12_Click(object sender, EventArgs e)
        {
            int nCol = 1;
            int nRow = 2;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic13_Click(object sender, EventArgs e)
        {
            int nCol = 1;
            int nRow = 3;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic14_Click(object sender, EventArgs e)
        {
            int nCol = 1;
            int nRow = 4;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }


        }

        private void pic15_Click(object sender, EventArgs e)
        {
            int nCol = 1;
            int nRow = 5;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic16_Click(object sender, EventArgs e)
        {
            int nCol = 1;
            int nRow = 6;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic17_Click(object sender, EventArgs e)
        {
            int nCol = 1;
            int nRow = 7;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }


        }

        private void pic18_Click(object sender, EventArgs e)
        {
            int nCol = 1;
            int nRow = 8;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic21_Click(object sender, EventArgs e)
        {
            int nCol = 2;
            int nRow = 1;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic22_Click(object sender, EventArgs e)
        {
            int nCol = 2;
            int nRow = 2;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic23_Click(object sender, EventArgs e)
        {
            int nCol = 2;
            int nRow = 3;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic24_Click(object sender, EventArgs e)
        {
            int nCol = 2;
            int nRow = 4;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic25_Click(object sender, EventArgs e)
        {
            int nCol = 2;
            int nRow = 5;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }


        }

        private void pic26_Click(object sender, EventArgs e)
        {
            int nCol = 2;
            int nRow = 6;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic27_Click(object sender, EventArgs e)
        {
            int nCol = 2;
            int nRow = 7;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic28_Click(object sender, EventArgs e)
        {
            int nCol = 2;
            int nRow = 8;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }


        }

        private void pic31_Click(object sender, EventArgs e)
        {
            int nCol = 3;
            int nRow = 1;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic32_Click(object sender, EventArgs e)
        {
            int nCol = 3;
            int nRow = 2;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic33_Click(object sender, EventArgs e)
        {
            int nCol = 3;
            int nRow = 3;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic34_Click(object sender, EventArgs e)
        {
            int nCol = 3;
            int nRow = 4;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic35_Click(object sender, EventArgs e)
        {
            int nCol = 3;
            int nRow = 5;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }


        }

        private void pic36_Click(object sender, EventArgs e)
        {
            int nCol = 3;
            int nRow = 6;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic37_Click(object sender, EventArgs e)
        {
            int nCol = 3;
            int nRow = 7;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic38_Click(object sender, EventArgs e)
        {
            int nCol = 3;
            int nRow = 8;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic41_Click(object sender, EventArgs e)
        {
            int nCol = 4;
            int nRow = 1;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic42_Click(object sender, EventArgs e)
        {
            int nCol = 4;
            int nRow = 2;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic43_Click(object sender, EventArgs e)
        {
            int nCol = 4;
            int nRow = 3;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic44_Click(object sender, EventArgs e)
        {
            int nCol = 4;
            int nRow = 4;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic45_Click(object sender, EventArgs e)
        {
            int nCol = 4;
            int nRow = 5;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic46_Click(object sender, EventArgs e)
        {
            int nCol = 4;
            int nRow = 6;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic47_Click(object sender, EventArgs e)
        {
            int nCol = 4;
            int nRow = 7;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic48_Click(object sender, EventArgs e)
        {
            int nCol = 4;
            int nRow = 8;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic51_Click(object sender, EventArgs e)
        {
            int nCol = 5;
            int nRow = 1;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic52_Click(object sender, EventArgs e)
        {
            int nCol = 5;
            int nRow = 2;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic53_Click(object sender, EventArgs e)
        {
            int nCol = 5;
            int nRow = 3;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic54_Click(object sender, EventArgs e)
        {
            int nCol = 5;
            int nRow = 4;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic55_Click(object sender, EventArgs e)
        {
            int nCol = 5;
            int nRow = 5;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic56_Click(object sender, EventArgs e)
        {
            int nCol = 5;
            int nRow = 6;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic57_Click(object sender, EventArgs e)
        {
            int nCol = 5;
            int nRow = 7;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic58_Click(object sender, EventArgs e)
        {
            int nCol = 5;
            int nRow = 8;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic61_Click(object sender, EventArgs e)
        {
            int nCol = 6;
            int nRow = 1;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic62_Click(object sender, EventArgs e)
        {
            int nCol = 6;
            int nRow = 2;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic63_Click(object sender, EventArgs e)
        {
            int nCol = 6;
            int nRow = 3;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic64_Click(object sender, EventArgs e)
        {
            int nCol = 6;
            int nRow = 4;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic65_Click(object sender, EventArgs e)
        {
            int nCol = 6;
            int nRow = 5;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic66_Click(object sender, EventArgs e)
        {
            int nCol = 6;
            int nRow = 6;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic67_Click(object sender, EventArgs e)
        {
            int nCol = 6;
            int nRow = 7;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic68_Click(object sender, EventArgs e)
        {
            int nCol = 6;
            int nRow = 8;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic71_Click(object sender, EventArgs e)
        {
            int nCol = 7;
            int nRow = 1;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic72_Click(object sender, EventArgs e)
        {
            int nCol = 7;
            int nRow = 2;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic73_Click(object sender, EventArgs e)
        {
            int nCol = 7;
            int nRow = 3;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic74_Click(object sender, EventArgs e)
        {
            int nCol = 7;
            int nRow = 4;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic75_Click(object sender, EventArgs e)
        {
            int nCol = 7;
            int nRow = 5;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic76_Click(object sender, EventArgs e)
        {
            int nCol = 7;
            int nRow = 6;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic77_Click(object sender, EventArgs e)
        {
            int nCol = 7;
            int nRow = 7;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic78_Click(object sender, EventArgs e)
        {
            int nCol = 7;
            int nRow = 8;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic81_Click(object sender, EventArgs e)
        {
            int nCol = 8;
            int nRow = 1;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic82_Click(object sender, EventArgs e)
        {
            int nCol = 8;
            int nRow = 2;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic83_Click(object sender, EventArgs e)
        {
            int nCol = 8;
            int nRow = 3;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic84_Click(object sender, EventArgs e)
        {
            int nCol = 8;
            int nRow = 4;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic85_Click(object sender, EventArgs e)
        {
            int nCol = 8;
            int nRow = 5;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic86_Click(object sender, EventArgs e)
        {
            int nCol = 8;
            int nRow = 6;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic87_Click(object sender, EventArgs e)
        {
            int nCol = 8;
            int nRow = 7;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }

        }

        private void pic88_Click(object sender, EventArgs e)
        {
            int nCol = 8;
            int nRow = 8;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }



        }



        private void btnNav1_Click(object sender, EventArgs e)
        {
            int nSavecol = mnCol;
            int nSaverow = mnRow;
            int nCol = mnCol;
            int nRow = mnRow;
            int nType;
            Random rnd1 = new Random();
            int nHP,nHPHit;
            int nAC;
             bool bExtrago=false;
            bool bMiss = false;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 3)
            {
                bExtrago = true;
            }

            if (mbPlayer)
            {
                if (mnMovesleft > 0)
                {
                    nRow = nRow - 1;
                    if (nRow != 0)
                    {
                        switch (nCol)
                        {
                            case 1:
                                nType = _col1[nRow - 1];
                                break;
                            case 2:
                                nType = _col2[nRow - 1];
                                break;
                            case 3:
                                nType = _col3[nRow - 1];
                                break;
                            case 4:
                                nType = _col4[nRow - 1];
                                break;
                            case 5:
                                nType = _col5[nRow - 1];
                                break;
                            case 6:
                                nType = _col6[nRow - 1];
                                break;
                            case 7:
                                nType = _col7[nRow - 1];
                                break;
                            default:
                                nType = _col8[nRow - 1];
                                break;
                        }
                        switch (nType)
                        {
                            case 1:
                                switch (nSavecol)
                                {
                                    case 1:
                                        _col1[nSaverow - 1] = 1;
                                        break;
                                    case 2:
                                        _col2[nSaverow - 1] = 1;
                                        break;
                                    case 3:
                                        _col3[nSaverow - 1] = 1;
                                        break;
                                    case 4:
                                        _col4[nSaverow - 1] = 1;
                                        break;
                                    case 5:
                                        _col5[nSaverow - 1] = 1;
                                        break;
                                    case 6:
                                        _col6[nSaverow - 1] = 1;
                                        break;
                                    case 7:
                                        _col7[nSaverow - 1] = 1;
                                        break;
                                    default:
                                        _col8[nSaverow - 1] = 1;
                                        break;

                                }
                                switch (nCol)
                                {
                                    case 1:
                                        _col1[nRow - 1] = 7;
                                        break;
                                    case 2:
                                        _col2[nRow - 1] = 7;
                                        break;
                                    case 3:
                                        _col3[nRow - 1] = 7;
                                        break;
                                    case 4:
                                        _col4[nRow - 1] = 7;
                                        break;
                                    case 5:
                                        _col5[nRow - 1] = 7;
                                        break;
                                    case 6:
                                        _col6[nRow - 1] = 7;
                                        break;
                                    case 7:
                                        _col7[nRow - 1] = 7;
                                        break;
                                    default:
                                        _col8[nRow - 1] = 7;
                                        break;

                                }
                                mnCol = nCol;
                                mnRow = nRow;
                                mnMovesleft -= 1;
                                break;
                            case 2:
                                 nHP = fHP(nCol, nRow);
                                nAC = _playerAC[mnPlayer - 1];
                                switch (nAC)
                                {
                                    case 2:
                                        nHPHit = rnd1.Next(6, 15);
                                        if (nHPHit > nHP)
                                        {
                                            nHPHit = nHP;
                                        }
                                        break;
                                    default:
                                        nHPHit = rnd1.Next(6, 9);
                                        if (nHPHit > nHP)
                                        {
                                            nHPHit = nHP;
                                        }
                                        break;
                                }
                                bMiss = fMiss();
                                if (bMiss)
                                {
                                    MessageBox.Show("Misses");
                                    nHP = rnd1.Next(1, 9);
                                    _playerHP[mnPlayer - 1] -= nHP;
                                    if (_playerHP[mnPlayer - 1] < 1)
                                    {
                                        MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " dies");
                                    }
                                }
                                else
                                {
                                    nHP -= nHPHit;
                                    fHPSet(nCol, nRow, nHP);
                                    if (nHP > 0)
                                    {
                                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                                    }
                                    else
                                    {
                                        fKill(nCol, nRow);
                                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                                    }
                                    if (bExtrago)
                                    {
                                        mnMovesleft -= 1;
                                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                                        if (mnMovesleft == 0)
                                        {
                                            fPNext();
                                        }
                                    }
                                    else
                                    {
                                        fPNext();
                                    }
                                }
                                break;
                            default:
                                MessageBox.Show("Error!");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            int nSavecol = mnCol;
            int nSaverow = mnRow;
            int nCol = mnCol;
            int nRow = mnRow;
            int nType;
            Random rnd1 = new Random();
            int nHP, nHPHit;
            int nAC;
             bool bExtrago = false;
            bool bMiss = false;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 3)
            {
                bExtrago = true;
            }

            if (mbPlayer)
            {
                if (mnMovesleft > 0)
                {
                    nRow = nRow - 1;
                    nCol = nCol + 1;
                    if (nRow != 0)
                    {
                        if (nCol != 9)
                        {


                            switch (nCol)
                            {
                                case 1:
                                    nType = _col1[nRow - 1];
                                    break;
                                case 2:
                                    nType = _col2[nRow - 1];
                                    break;
                                case 3:
                                    nType = _col3[nRow - 1];
                                    break;
                                case 4:
                                    nType = _col4[nRow - 1];
                                    break;
                                case 5:
                                    nType = _col5[nRow - 1];
                                    break;
                                case 6:
                                    nType = _col6[nRow - 1];
                                    break;
                                case 7:
                                    nType = _col7[nRow - 1];
                                    break;
                                default:
                                    nType = _col8[nRow - 1];
                                    break;
                            }
                            switch (nType)
                            {
                                case 1:
                                    switch (nSavecol)
                                    {
                                        case 1:
                                            _col1[nSaverow - 1] = 1;
                                            break;
                                        case 2:
                                            _col2[nSaverow - 1] = 1;
                                            break;
                                        case 3:
                                            _col3[nSaverow - 1] = 1;
                                            break;
                                        case 4:
                                            _col4[nSaverow - 1] = 1;
                                            break;
                                        case 5:
                                            _col5[nSaverow - 1] = 1;
                                            break;
                                        case 6:
                                            _col6[nSaverow - 1] = 1;
                                            break;
                                        case 7:
                                            _col7[nSaverow - 1] = 1;
                                            break;
                                        default:
                                            _col8[nSaverow - 1] = 1;
                                            break;

                                    }
                                    switch (nCol)
                                    {
                                        case 1:
                                            _col1[nRow - 1] = 7;
                                            break;
                                        case 2:
                                            _col2[nRow - 1] = 7;
                                            break;
                                        case 3:
                                            _col3[nRow - 1] = 7;
                                            break;
                                        case 4:
                                            _col4[nRow - 1] = 7;
                                            break;
                                        case 5:
                                            _col5[nRow - 1] = 7;
                                            break;
                                        case 6:
                                            _col6[nRow - 1] = 7;
                                            break;
                                        case 7:
                                            _col7[nRow - 1] = 7;
                                            break;
                                        default:
                                            _col8[nRow - 1] = 7;
                                            break;

                                    }
                                    mnCol = nCol;
                                    mnRow = nRow;
                                    mnMovesleft -= 1;
                                    break;
                                case 2:
                                    nHP = fHP(nCol, nRow);
                                    nAC = _playerAC[mnPlayer - 1];
                                    switch (nAC)
                                    {
                                        case 2:
                                            nHPHit = rnd1.Next(6, 15);
                                            if (nHPHit > nHP)
                                            {
                                                nHPHit = nHP;
                                            }
                                            break;
                                        default:
                                            nHPHit = rnd1.Next(6, 9);
                                            if (nHPHit > nHP)
                                            {
                                                nHPHit = nHP;
                                            }
                                            break;
                                    }
                                    bMiss = fMiss();
                                    if (bMiss)
                                    {
                                        MessageBox.Show("Misses");
                                        nHP = rnd1.Next(1, 9);
                                        _playerHP[mnPlayer - 1] -= nHP;
                                        if (_playerHP[mnPlayer - 1] < 1)
                                        {
                                            MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " dies");
                                        }
                                    }
                                    else
                                    {
                                        nHP -= nHPHit;
                                        fHPSet(nCol, nRow, nHP);
                                        if (nHP > 0)
                                        {
                                            MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                                        }
                                        else
                                        {
                                            fKill(nCol, nRow);
                                            MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                                        }
                                        if (bExtrago)
                                        {
                                            mnMovesleft -= 1;
                                            lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                                            if (mnMovesleft == 0)
                                            {
                                                fPNext();
                                            }
                                        }
                                        else
                                        {
                                            fPNext();
                                        }
                                    }
                                    break;
                                default:
                                    MessageBox.Show("Error!");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            int nSavecol = mnCol;
            int nSaverow = mnRow;
            int nCol = mnCol;
            int nRow = mnRow;
            int nType;
            Random rnd1 = new Random();
            int nHP, nHPHit;
            int nAC;
             bool bExtrago = false;
            bool bMiss = false;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 3)
            {
                bExtrago = true;
            }

            if (mbPlayer)
            {
                if (mnMovesleft > 0)
                {
                    nCol = nCol + 1;
                    if (nCol != 9)
                    {
                        switch (nCol)
                        {
                            case 1:
                                nType = _col1[nRow - 1];
                                break;
                            case 2:
                                nType = _col2[nRow - 1];
                                break;
                            case 3:
                                nType = _col3[nRow - 1];
                                break;
                            case 4:
                                nType = _col4[nRow - 1];
                                break;
                            case 5:
                                nType = _col5[nRow - 1];
                                break;
                            case 6:
                                nType = _col6[nRow - 1];
                                break;
                            case 7:
                                nType = _col7[nRow - 1];
                                break;
                            default:
                                nType = _col8[nRow - 1];
                                break;
                        }
                        switch (nType)
                        {
                            case 1:
                                switch (nSavecol)
                                {
                                    case 1:
                                        _col1[nSaverow - 1] = 1;
                                        break;
                                    case 2:
                                        _col2[nSaverow - 1] = 1;
                                        break;
                                    case 3:
                                        _col3[nSaverow - 1] = 1;
                                        break;
                                    case 4:
                                        _col4[nSaverow - 1] = 1;
                                        break;
                                    case 5:
                                        _col5[nSaverow - 1] = 1;
                                        break;
                                    case 6:
                                        _col6[nSaverow - 1] = 1;
                                        break;
                                    case 7:
                                        _col7[nSaverow - 1] = 1;
                                        break;
                                    default:
                                        _col8[nSaverow - 1] = 1;
                                        break;

                                }
                                switch (nCol)
                                {
                                    case 1:
                                        _col1[nRow - 1] = 7;
                                        break;
                                    case 2:
                                        _col2[nRow - 1] = 7;
                                        break;
                                    case 3:
                                        _col3[nRow - 1] = 7;
                                        break;
                                    case 4:
                                        _col4[nRow - 1] = 7;
                                        break;
                                    case 5:
                                        _col5[nRow - 1] = 7;
                                        break;
                                    case 6:
                                        _col6[nRow - 1] = 7;
                                        break;
                                    case 7:
                                        _col7[nRow - 1] = 7;
                                        break;
                                    default:
                                        _col8[nRow - 1] = 7;
                                        break;

                                }
                                mnCol = nCol;
                                mnRow = nRow;
                                mnMovesleft -= 1;
                                break;
                            case 2:
                                nHP = fHP(nCol, nRow);
                                nAC = _playerAC[mnPlayer - 1];
                                switch (nAC)
                                {
                                    case 2:
                                        nHPHit = rnd1.Next(6, 15);
                                        if (nHPHit > nHP)
                                        {
                                            nHPHit = nHP;
                                        }
                                        break;
                                    default:
                                        nHPHit = rnd1.Next(6, 9);
                                        if (nHPHit > nHP)
                                        {
                                            nHPHit = nHP;
                                        }
                                        break;
                                }
                                bMiss = fMiss();
                                if (bMiss)
                                {
                                    MessageBox.Show("Misses");
                                    nHP = rnd1.Next(1, 9);
                                    _playerHP[mnPlayer - 1] -= nHP;
                                    if (_playerHP[mnPlayer - 1] < 1)
                                    {
                                        MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " dies");
                                    }
                                }
                                else
                                {
                                    nHP -= nHPHit;
                                    fHPSet(nCol, nRow, nHP);
                                    if (nHP > 0)
                                    {
                                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                                    }
                                    else
                                    {
                                        fKill(nCol, nRow);
                                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                                    }
                                    if (bExtrago)
                                    {
                                        mnMovesleft -= 1;
                                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                                        if (mnMovesleft == 0)
                                        {
                                            fPNext();
                                        }
                                    }
                                    else
                                    {
                                        fPNext();
                                    }
                                }
                                break;
                            default:
                                MessageBox.Show("Error!");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            int nSavecol = mnCol;
            int nSaverow = mnRow;
            int nCol = mnCol;
            int nRow = mnRow;
            int nType;
            Random rnd1 = new Random();
            int nHP, nHPHit;
            int nAC;
            bool bExtrago = false;
            bool bMiss = false;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 3)
            {
                bExtrago = true;
            }

            if (mbPlayer)
            {
                if (mnMovesleft > 0)
                {
                    nRow = nRow + 1;
                    nCol = nCol + 1;
                    if (nRow != 9)
                    {
                        if (nCol != 9)
                        {


                            switch (nCol)
                            {
                                case 1:
                                    nType = _col1[nRow - 1];
                                    break;
                                case 2:
                                    nType = _col2[nRow - 1];
                                    break;
                                case 3:
                                    nType = _col3[nRow - 1];
                                    break;
                                case 4:
                                    nType = _col4[nRow - 1];
                                    break;
                                case 5:
                                    nType = _col5[nRow - 1];
                                    break;
                                case 6:
                                    nType = _col6[nRow - 1];
                                    break;
                                case 7:
                                    nType = _col7[nRow - 1];
                                    break;
                                default:
                                    nType = _col8[nRow - 1];
                                    break;
                            }
                            switch (nType)
                            {
                                case 1:
                                    switch (nSavecol)
                                    {
                                        case 1:
                                            _col1[nSaverow - 1] = 1;
                                            break;
                                        case 2:
                                            _col2[nSaverow - 1] = 1;
                                            break;
                                        case 3:
                                            _col3[nSaverow - 1] = 1;
                                            break;
                                        case 4:
                                            _col4[nSaverow - 1] = 1;
                                            break;
                                        case 5:
                                            _col5[nSaverow - 1] = 1;
                                            break;
                                        case 6:
                                            _col6[nSaverow - 1] = 1;
                                            break;
                                        case 7:
                                            _col7[nSaverow - 1] = 1;
                                            break;
                                        default:
                                            _col8[nSaverow - 1] = 1;
                                            break;

                                    }
                                    switch (nCol)
                                    {
                                        case 1:
                                            _col1[nRow - 1] = 7;
                                            break;
                                        case 2:
                                            _col2[nRow - 1] = 7;
                                            break;
                                        case 3:
                                            _col3[nRow - 1] = 7;
                                            break;
                                        case 4:
                                            _col4[nRow - 1] = 7;
                                            break;
                                        case 5:
                                            _col5[nRow - 1] = 7;
                                            break;
                                        case 6:
                                            _col6[nRow - 1] = 7;
                                            break;
                                        case 7:
                                            _col7[nRow - 1] = 7;
                                            break;
                                        default:
                                            _col8[nRow - 1] = 7;
                                            break;

                                    }
                                    mnCol = nCol;
                                    mnRow = nRow;
                                    mnMovesleft -= 1;
                                    break;
                                case 2:
                                    nHP = fHP(nCol, nRow);
                                    nAC = _playerAC[mnPlayer - 1];
                                    switch (nAC)
                                    {
                                        case 2:
                                            nHPHit = rnd1.Next(6, 15);
                                            if (nHPHit > nHP)
                                            {
                                                nHPHit = nHP;
                                            }
                                            break;
                                        default:
                                            nHPHit = rnd1.Next(6, 9);
                                            if (nHPHit > nHP)
                                            {
                                                nHPHit = nHP;
                                            }
                                            break;
                                    }
                                    bMiss = fMiss();
                                    if (bMiss)
                                    {
                                        MessageBox.Show("Misses");
                                        nHP = rnd1.Next(1, 9);
                                        _playerHP[mnPlayer - 1] -= nHP;
                                        if (_playerHP[mnPlayer - 1] < 1)
                                        {
                                            MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " dies");
                                        }
                                    }
                                    else
                                    {
                                        nHP -= nHPHit;
                                        fHPSet(nCol, nRow, nHP);
                                        if (nHP > 0)
                                        {
                                            MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                                        }
                                        else
                                        {
                                            fKill(nCol, nRow);
                                            MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                                        }
                                        if (bExtrago)
                                        {
                                            mnMovesleft -= 1;
                                            lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                                            if (mnMovesleft == 0)
                                            {
                                                fPNext();
                                            }
                                        }
                                        else
                                        {
                                            fPNext();
                                        }
                                    }
                                    break;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }

            }
        }

        private void btnNav5_Click(object sender, EventArgs e)
        {
            int nSavecol = mnCol;
            int nSaverow = mnRow;
            int nCol = mnCol;
            int nRow = mnRow;
            int nType;
            Random rnd1 = new Random();
            int nHP, nHPHit;
            int nAC;
            bool bExtrago = false;
            bool bMiss = false;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 3)
            {
                bExtrago = true;
            }

            if (mbPlayer)
            {
                if (mnMovesleft > 0)
                {
                    nRow = nRow + 1;
                    if (nRow != 9)
                    {
                        switch (nCol)
                        {
                            case 1:
                                nType = _col1[nRow - 1];
                                break;
                            case 2:
                                nType = _col2[nRow - 1];
                                break;
                            case 3:
                                nType = _col3[nRow - 1];
                                break;
                            case 4:
                                nType = _col4[nRow - 1];
                                break;
                            case 5:
                                nType = _col5[nRow - 1];
                                break;
                            case 6:
                                nType = _col6[nRow - 1];
                                break;
                            case 7:
                                nType = _col7[nRow - 1];
                                break;
                            default:
                                nType = _col8[nRow - 1];
                                break;
                        }
                        switch (nType)
                        {
                            case 1:
                                switch (nSavecol)
                                {
                                    case 1:
                                        _col1[nSaverow - 1] = 1;
                                        break;
                                    case 2:
                                        _col2[nSaverow - 1] = 1;
                                        break;
                                    case 3:
                                        _col3[nSaverow - 1] = 1;
                                        break;
                                    case 4:
                                        _col4[nSaverow - 1] = 1;
                                        break;
                                    case 5:
                                        _col5[nSaverow - 1] = 1;
                                        break;
                                    case 6:
                                        _col6[nSaverow - 1] = 1;
                                        break;
                                    case 7:
                                        _col7[nSaverow - 1] = 1;
                                        break;
                                    default:
                                        _col8[nSaverow - 1] = 1;
                                        break;

                                }
                                switch (nCol)
                                {
                                    case 1:
                                        _col1[nRow - 1] = 7;
                                        break;
                                    case 2:
                                        _col2[nRow - 1] = 7;
                                        break;
                                    case 3:
                                        _col3[nRow - 1] = 7;
                                        break;
                                    case 4:
                                        _col4[nRow - 1] = 7;
                                        break;
                                    case 5:
                                        _col5[nRow - 1] = 7;
                                        break;
                                    case 6:
                                        _col6[nRow - 1] = 7;
                                        break;
                                    case 7:
                                        _col7[nRow - 1] = 7;
                                        break;
                                    default:
                                        _col8[nRow - 1] = 7;
                                        break;

                                }
                                mnCol = nCol;
                                mnRow = nRow;
                                mnMovesleft -= 1;
                                break;
                            case 2:
                                nHP = fHP(nCol, nRow);
                                nAC = _playerAC[mnPlayer - 1];
                                switch (nAC)
                                {
                                    case 2:
                                        nHPHit = rnd1.Next(6, 15);
                                        if (nHPHit > nHP)
                                        {
                                            nHPHit = nHP;
                                        }
                                        break;
                                    default:
                                        nHPHit = rnd1.Next(6, 9);
                                        if (nHPHit > nHP)
                                        {
                                            nHPHit = nHP;
                                        }
                                        break;
                                }
                                bMiss = fMiss();
                                if (bMiss)
                                {
                                    MessageBox.Show("Misses");
                                    nHP = rnd1.Next(1, 9);
                                    _playerHP[mnPlayer - 1] -= nHP;
                                    if (_playerHP[mnPlayer - 1] < 1)
                                    {
                                        MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " dies");
                                    }
                                }
                                else
                                {
                                    nHP -= nHPHit;
                                    fHPSet(nCol, nRow, nHP);
                                    if (nHP > 0)
                                    {
                                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                                    }
                                    else
                                    {
                                        fKill(nCol, nRow);
                                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                                    }
                                    if (bExtrago)
                                    {
                                        mnMovesleft -= 1;
                                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                                        if (mnMovesleft == 0)
                                        {
                                            fPNext();
                                        }
                                    }
                                    else
                                    {
                                        fPNext();
                                    }
                                }
                                break;
                            default:
                                MessageBox.Show("Error!");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnNav6_Click(object sender, EventArgs e)
        {
            int nSavecol = mnCol;
            int nSaverow = mnRow;
            int nCol = mnCol;
            int nRow = mnRow;
            int nType;
            Random rnd1 = new Random();
            int nHP, nHPHit;
            int nAC;
             bool bExtrago = false;
            bool bMiss = false;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 3)
            {
                bExtrago = true;
            }

            if (mbPlayer)
            {
                if (mnMovesleft > 0)
                {
                    nRow = nRow + 1;
                    nCol = nCol - 1;
                    if (nRow != 9)
                    {
                        if (nCol != 0)
                        {


                            switch (nCol)
                            {
                                case 1:
                                    nType = _col1[nRow - 1];
                                    break;
                                case 2:
                                    nType = _col2[nRow - 1];
                                    break;
                                case 3:
                                    nType = _col3[nRow - 1];
                                    break;
                                case 4:
                                    nType = _col4[nRow - 1];
                                    break;
                                case 5:
                                    nType = _col5[nRow - 1];
                                    break;
                                case 6:
                                    nType = _col6[nRow - 1];
                                    break;
                                case 7:
                                    nType = _col7[nRow - 1];
                                    break;
                                default:
                                    nType = _col8[nRow - 1];
                                    break;
                            }
                            switch (nType)
                            {
                                case 1:
                                    switch (nSavecol)
                                    {
                                        case 1:
                                            _col1[nSaverow - 1] = 1;
                                            break;
                                        case 2:
                                            _col2[nSaverow - 1] = 1;
                                            break;
                                        case 3:
                                            _col3[nSaverow - 1] = 1;
                                            break;
                                        case 4:
                                            _col4[nSaverow - 1] = 1;
                                            break;
                                        case 5:
                                            _col5[nSaverow - 1] = 1;
                                            break;
                                        case 6:
                                            _col6[nSaverow - 1] = 1;
                                            break;
                                        case 7:
                                            _col7[nSaverow - 1] = 1;
                                            break;
                                        default:
                                            _col8[nSaverow - 1] = 1;
                                            break;

                                    }
                                    switch (nCol)
                                    {
                                        case 1:
                                            _col1[nRow - 1] = 7;
                                            break;
                                        case 2:
                                            _col2[nRow - 1] = 7;
                                            break;
                                        case 3:
                                            _col3[nRow - 1] = 7;
                                            break;
                                        case 4:
                                            _col4[nRow - 1] = 7;
                                            break;
                                        case 5:
                                            _col5[nRow - 1] = 7;
                                            break;
                                        case 6:
                                            _col6[nRow - 1] = 7;
                                            break;
                                        case 7:
                                            _col7[nRow - 1] = 7;
                                            break;
                                        default:
                                            _col8[nRow - 1] = 7;
                                            break;

                                    }
                                    mnCol = nCol;
                                    mnRow = nRow;
                                    mnMovesleft -= 1;
                                    break;
                                case 2:
                                    nHP = fHP(nCol, nRow);
                                    nAC = _playerAC[mnPlayer - 1];
                                    switch (nAC)
                                    {
                                        case 2:
                                            nHPHit = rnd1.Next(6, 15);
                                            if (nHPHit > nHP)
                                            {
                                                nHPHit = nHP;
                                            }
                                            break;
                                        default:
                                            nHPHit = rnd1.Next(6, 9);
                                            if (nHPHit > nHP)
                                            {
                                                nHPHit = nHP;
                                            }
                                            break;
                                    }
                                    bMiss = fMiss();
                                    if (bMiss)
                                    {
                                        MessageBox.Show("Misses");
                                        nHP = rnd1.Next(1, 9);
                                        _playerHP[mnPlayer - 1] -= nHP;
                                        if (_playerHP[mnPlayer - 1] < 1)
                                        {
                                            MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " dies");
                                        }
                                    }
                                    else
                                    {
                                        nHP -= nHPHit;
                                        fHPSet(nCol, nRow, nHP);
                                        if (nHP > 0)
                                        {
                                            MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                                        }
                                        else
                                        {
                                            fKill(nCol, nRow);
                                            MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                                        }
                                        if (bExtrago)
                                        {
                                            mnMovesleft -= 1;
                                            lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                                            if (mnMovesleft == 0)
                                            {
                                                fPNext();
                                            }
                                        }
                                        else
                                        {
                                            fPNext();
                                        }
                                    }
                                    break;
                                default:
                                    MessageBox.Show("Error!");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnNav7_Click(object sender, EventArgs e)
        {
            int nSavecol = mnCol;
            int nSaverow = mnRow;
            int nCol = mnCol;
            int nRow = mnRow;
            int nType;
            Random rnd1 = new Random();
            int nHP, nHPHit;
            int nAC;
            bool bExtrago = false;
            bool bMiss = false;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 3)
            {
                bExtrago = true;
            }

            if (mbPlayer)
            {
                if (mnMovesleft > 0)
                {
                    nCol = nCol - 1;
                    if (nCol != 0)
                    {
                        switch (nCol)
                        {
                            case 1:
                                nType = _col1[nRow - 1];
                                break;
                            case 2:
                                nType = _col2[nRow - 1];
                                break;
                            case 3:
                                nType = _col3[nRow - 1];
                                break;
                            case 4:
                                nType = _col4[nRow - 1];
                                break;
                            case 5:
                                nType = _col5[nRow - 1];
                                break;
                            case 6:
                                nType = _col6[nRow - 1];
                                break;
                            case 7:
                                nType = _col7[nRow - 1];
                                break;
                            default:
                                nType = _col8[nRow - 1];
                                break;
                        }
                        switch (nType)
                        {
                            case 1:
                                switch (nSavecol)
                                {
                                    case 1:
                                        _col1[nSaverow - 1] = 1;
                                        break;
                                    case 2:
                                        _col2[nSaverow - 1] = 1;
                                        break;
                                    case 3:
                                        _col3[nSaverow - 1] = 1;
                                        break;
                                    case 4:
                                        _col4[nSaverow - 1] = 1;
                                        break;
                                    case 5:
                                        _col5[nSaverow - 1] = 1;
                                        break;
                                    case 6:
                                        _col6[nSaverow - 1] = 1;
                                        break;
                                    case 7:
                                        _col7[nSaverow - 1] = 1;
                                        break;
                                    default:
                                        _col8[nSaverow - 1] = 1;
                                        break;

                                }
                                switch (nCol)
                                {
                                    case 1:
                                        _col1[nRow - 1] = 7;
                                        break;
                                    case 2:
                                        _col2[nRow - 1] = 7;
                                        break;
                                    case 3:
                                        _col3[nRow - 1] = 7;
                                        break;
                                    case 4:
                                        _col4[nRow - 1] = 7;
                                        break;
                                    case 5:
                                        _col5[nRow - 1] = 7;
                                        break;
                                    case 6:
                                        _col6[nRow - 1] = 7;
                                        break;
                                    case 7:
                                        _col7[nRow - 1] = 7;
                                        break;
                                    default:
                                        _col8[nRow - 1] = 7;
                                        break;

                                }
                                mnCol = nCol;
                                mnRow = nRow;
                                mnMovesleft -= 1;
                                break;
                            case 2:
                                  nHP = fHP(nCol, nRow);
                                nAC = _playerAC[mnPlayer - 1];
                                switch (nAC)
                                {
                                    case 2:
                                        nHPHit = rnd1.Next(6, 15);
                                        if (nHPHit > nHP)
                                        {
                                            nHPHit = nHP;
                                        }
                                        break;
                                    default:
                                        nHPHit = rnd1.Next(6, 9);
                                        if (nHPHit > nHP)
                                        {
                                            nHPHit = nHP;
                                        }
                                        break;
                                }
                                bMiss = fMiss();
                                if (bMiss)
                                {
                                    MessageBox.Show("Misses");
                                    nHP = rnd1.Next(1, 9);
                                    _playerHP[mnPlayer - 1] -= nHP;
                                    if (_playerHP[mnPlayer - 1] < 1)
                                    {
                                        MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " dies");
                                    }
                                }
                                else
                                {
                                    nHP -= nHPHit;
                                    fHPSet(nCol, nRow, nHP);
                                    if (nHP > 0)
                                    {
                                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                                    }
                                    else
                                    {
                                        fKill(nCol, nRow);
                                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                                    }
                                    if (bExtrago)
                                    {
                                        mnMovesleft -= 1;
                                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                                        if (mnMovesleft == 0)
                                        {
                                            fPNext();
                                        }
                                    }
                                    else
                                    {
                                        fPNext();
                                    }
                                }
                                break;
                            default:
                                MessageBox.Show("Error!");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnNav8_Click(object sender, EventArgs e)
        {
            int nSavecol = mnCol;
            int nSaverow = mnRow;
            int nCol = mnCol;
            int nRow = mnRow;
            int nType;
            Random rnd1 = new Random();
            int nHP, nHPHit;
            int nAC;
             bool bExtrago = false;
            bool bMiss = false;

            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 3)
            {
                bExtrago = true;
            }

            if (mbPlayer)
            {
                if (mnMovesleft > 0)
                {
                    nRow = nRow - 1;
                    nCol = nCol - 1;
                    if (nRow != 0)
                    {
                        if (nCol != 0)
                        {


                            switch (nCol)
                            {
                                case 1:
                                    nType = _col1[nRow - 1];
                                    break;
                                case 2:
                                    nType = _col2[nRow - 1];
                                    break;
                                case 3:
                                    nType = _col3[nRow - 1];
                                    break;
                                case 4:
                                    nType = _col4[nRow - 1];
                                    break;
                                case 5:
                                    nType = _col5[nRow - 1];
                                    break;
                                case 6:
                                    nType = _col6[nRow - 1];
                                    break;
                                case 7:
                                    nType = _col7[nRow - 1];
                                    break;
                                default:
                                    nType = _col8[nRow - 1];
                                    break;
                            }
                            switch (nType)
                            {
                                case 1:
                                    switch (nSavecol)
                                    {
                                        case 1:
                                            _col1[nSaverow - 1] = 1;
                                            break;
                                        case 2:
                                            _col2[nSaverow - 1] = 1;
                                            break;
                                        case 3:
                                            _col3[nSaverow - 1] = 1;
                                            break;
                                        case 4:
                                            _col4[nSaverow - 1] = 1;
                                            break;
                                        case 5:
                                            _col5[nSaverow - 1] = 1;
                                            break;
                                        case 6:
                                            _col6[nSaverow - 1] = 1;
                                            break;
                                        case 7:
                                            _col7[nSaverow - 1] = 1;
                                            break;
                                        default:
                                            _col8[nSaverow - 1] = 1;
                                            break;

                                    }
                                    switch (nCol)
                                    {
                                        case 1:
                                            _col1[nRow - 1] = 7;
                                            break;
                                        case 2:
                                            _col2[nRow - 1] = 7;
                                            break;
                                        case 3:
                                            _col3[nRow - 1] = 7;
                                            break;
                                        case 4:
                                            _col4[nRow - 1] = 7;
                                            break;
                                        case 5:
                                            _col5[nRow - 1] = 7;
                                            break;
                                        case 6:
                                            _col6[nRow - 1] = 7;
                                            break;
                                        case 7:
                                            _col7[nRow - 1] = 7;
                                            break;
                                        default:
                                            _col8[nRow - 1] = 7;
                                            break;

                                    }
                                    mnCol = nCol;
                                    mnRow = nRow;
                                    mnMovesleft -= 1;
                                    break;
                                case 2:
                                    nHP = fHP(nCol, nRow);
                                    nAC = _playerAC[mnPlayer - 1];
                                    switch (nAC)
                                    {
                                        case 2:
                                            nHPHit = rnd1.Next(6, 15);
                                            if (nHPHit > nHP)
                                            {
                                                nHPHit = nHP;
                                            }
                                            break;
                                        default:
                                            nHPHit = rnd1.Next(6, 9);
                                            if (nHPHit > nHP)
                                            {
                                                nHPHit = nHP;
                                            }
                                            break;
                                    }
                                    bMiss = fMiss();
                                    if (bMiss)
                                    {
                                        MessageBox.Show("Misses");
                                        nHP = rnd1.Next(1, 9);
                                        _playerHP[mnPlayer - 1] -= nHP;
                                        if (_playerHP[mnPlayer - 1] < 1)
                                        {
                                            MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " dies");
                                        }
                                    }
                                    else
                                    {
                                        nHP -= nHPHit;
                                        fHPSet(nCol, nRow, nHP);
                                        if (nHP > 0)
                                        {
                                            MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                                        }
                                        else
                                        {
                                            fKill(nCol, nRow);
                                            MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                                        }
                                        if (bExtrago)
                                        {
                                            mnMovesleft -= 1;
                                            lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                                            if (mnMovesleft == 0)
                                            {
                                                fPNext();
                                            }
                                        }
                                        else
                                        {
                                            fPNext();
                                        }
                                    }
                                    break;
                                default:
                                    MessageBox.Show("Error!");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnVoid2_Click(object sender, EventArgs e)
        {
            int nPlayer = 0;
            nPlayer = fPlayer(mnSavecol, mnSaverow);
              lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

             if (nPlayer > 0)
            {
                _playerAC[nPlayer-1] = 4;
                lblSelected.Text = lblSelected.Text + " (Player" + Convert.ToString(nPlayer) + ")";
                mnSavecol = mnCol;
                mnSaverow = mnRow;
                fraPlayer.Text = "Player" + Convert.ToString(nPlayer);
                fraPlayer.Visible = true;
                lblVoid1.Text = "HP = " + Convert.ToString(_playerHP[nPlayer - 1]);
                lblVoid2.Text = "SP = " + Convert.ToString(_playerSP[nPlayer - 1]);
                lblVoid3.Text = "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
            }
            else
            {
                fraPlayer.Visible = false;
            }



            lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);

            fUpdateDisplay();
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " guards");
            fPNext();
        }

        private void tmrKill_Tick(object sender, EventArgs e)
        {
            switch (mnKillCol)
            {
                case 1:
                    _col1[mnKillRow - 1] = 1;
                    break;
                case 2:
                    _col2[mnKillRow - 1] = 1;
                    break;
                case 3:
                    _col3[mnKillRow - 1] = 1;
                    break;
                case 4:
                    _col4[mnKillRow - 1] = 1;
                    break;
                case 5:
                    _col5[mnKillRow - 1] = 1;
                    break;
                case 6:
                    _col6[mnKillRow - 1] = 1;
                    break;
                case 7:
                    _col7[mnKillRow - 1] = 1;
                    break;
                default:
                    _col8[mnKillRow - 1] = 1;
                    break;
            }
            fUpdateDisplay();
            tmrKill.Enabled = true;

        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            mbUsearrow = true;
        }

        private void btnVoid1_Click(object sender, EventArgs e)
        {
            int nPlayer = 0;
            nPlayer = fPlayer(mnSavecol, mnSaverow);
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

            if (nPlayer > 0)
            {
                _playerAC[nPlayer-1] = 2;
                lblSelected.Text = lblSelected.Text + " (Player" + Convert.ToString(nPlayer) + ")";
                mnSavecol = mnCol;
                mnSaverow = mnRow;
                fraPlayer.Text = "Player" + Convert.ToString(nPlayer);
                fraPlayer.Visible = true;
                lblVoid1.Text = "HP = " + Convert.ToString(_playerHP[nPlayer - 1]);
                lblVoid2.Text = "SP = " + Convert.ToString(_playerSP[nPlayer - 1]);
                lblVoid3.Text = "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
            }
            else
            {
                fraPlayer.Visible = false;
            }



            lblMovesleft.Text = "MOVESLEFT = "+Convert.ToString(mnMovesleft);

            fUpdateDisplay();
        }

        private void btnUpdateDisplay_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

            int nPlayer = 0;
            nPlayer = fPlayer(mnSavecol, mnSaverow);
            if (nPlayer > 0)
            {
                lblSelected.Text = lblSelected.Text + " (Player" + Convert.ToString(nPlayer) + ")";
                mnSavecol = mnCol;
                mnSaverow = mnRow;
                _playercol[nPlayer - 1] = mnCol;
                _playerrow[nPlayer - 1] = mnRow;
                fraPlayer.Text = "Player" + Convert.ToString(nPlayer);
                fraPlayer.Visible = true;
                lblVoid1.Text = "HP = " + Convert.ToString(_playerHP[nPlayer - 1]);
                lblVoid2.Text = "SP = " + Convert.ToString(_playerSP[nPlayer - 1]);
                lblVoid3.Text = "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
            }
            else
            {
                fraPlayer.Visible = false;
            }

        

            lblMovesleft.Text = "MOVESLEFT = "+Convert.ToString(mnMovesleft);

            fUpdateDisplay();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            int nCol = 1;
            int nRow = 1;
            String sText = null;

            if (mbUsearrow)
            {
                Random rnd1 = new Random();
                int nHP = fHP(nCol, nRow);
                int nHPHit;
                bool bExtrago = false;

                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 3)
                {
                    bExtrago = true;
                }
                if (nHP == 0)
                {
                    MessageBox.Show("Player" + Convert.ToString(mnPlayer) + " misses");
                    fPNext();
                }
                else
                {
                    nHPHit = rnd1.Next(6, 9);
                    if (nHPHit > nHP)
                    {
                        nHPHit = nHP;
                    }
                    nHP -= nHPHit;
                    fHPSet(nCol, nRow, nHP);
                    if (nHP > 0)
                    {
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy at " + Convert.ToString(nHP));
                    }
                    else
                    {
                        fKill(nCol, nRow);
                        MessageBox.Show("Thrashes for " + Convert.ToString(nHPHit) + "HP", "Enemy dies!!!");
                    }
                    if (bExtrago)
                    {
                        mnMovesleft -= 1;
                        lblMovesleft.Text = "MOVESLEFT = " + Convert.ToString(mnMovesleft);
                        if (mnMovesleft == 0)
                        {
                            fPNext();
                        }
                    }
                    else
                    {
                        fPNext();
                    }
                }
            }
            else
            {
                int nPlayer = 0;
                nPlayer = fPlayer(nCol, nRow);
                if (nPlayer > 0)
                {
                    sText = "Player" + Convert.ToString(nPlayer) + "\n";
                    sText = sText + "HP = " + Convert.ToString(_playerHP[nPlayer - 1]) + "\n";
                    sText = sText + "SP = " + Convert.ToString(_playerSP[nPlayer - 1]) + "\n";
                    sText = sText + "AC = " + Convert.ToString(_playerAC[nPlayer - 1]);
                    MessageBox.Show(sText);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrKill.Enabled = false;
            fReset();
            fUpdateDisplay();
            fPNext();
        }
    }
}

