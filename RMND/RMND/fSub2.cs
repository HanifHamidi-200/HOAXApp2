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
    public partial class fSub2 : Form
    {
        private cBoard _board = new cBoard();
        private List<String> _pile1 = new List<string> { null, null, null, null };
        private List<String> _pile2 = new List<string> { null, null, null, null };
        private List<String> _pile3 = new List<string> { null, null, null, null };
        private List<String> _pile4 = new List<string> { null, null, null, null };
        private List<String> _pile5 = new List<string> { null, null, null, null };
        private List<String> _pile6 = new List<string> { null, null, null, null };
        private List<String> _pile7 = new List<string> { null, null, null, null };
        private List<String> _pile8 = new List<string> { null, null, null, null };
        private List<String> _pile9 = new List<string> { null, null, null, null };
        private List<String> _pile10 = new List<string> { null, null, null, null };
        private List<String> _pile11= new List<string> { null, null, null, null };
        private List<String> _pile12 = new List<string> { null, null, null, null };
        private List<String> _pile13 = new List<string> { null, null, null, null };
        private int mnCol, mnRow;
        private cCard _first = new cCard();
        private cCard _second = new cCard();

        private void fUpdateStatus()
        {
            lblCol.Text = "mnCol (/4) = " + Convert.ToString(mnCol);
        }
        private void fReset()
        {
            String sText,sText2;

            mnCol = 1;
            mnRow = 1;
            fUpdateStatus();
            _first.fSet2(1, 1);
            _second.fSet2(1, 1);


            for (int i = 1; i <= 8; i++)
            {
                _board.fSet(1, i);
                _board.fInit();
                _board.fSet(2, i);
                _board.fInit();
                _board.fSet(3, i);
                _board.fInit();
                _board.fSet(4, i);
                _board.fInit();
             }

            for (int i = 1; i <= 13; i++)
            {
                switch (i)
                {
                    case 1:
                        sText = "A";
                        _pile1[0] = sText + "S";
                        _pile1[1] = sText + "C";
                        _pile1[2] = sText + "H";
                        _pile1[3] = sText + "D";
                        break;
                    case 10:
                        sText = "T";
                        _pile10[0] = sText + "S";
                        _pile10[1] = sText + "C";
                        _pile10[2] = sText + "H";
                        _pile10[3] = sText + "D";
                        break;
                    case 11:
                        sText = "J";
                        _pile11[0] = sText + "S";
                        _pile11[1] = sText + "C";
                        _pile11[2] = sText + "H";
                        _pile11[3] = sText + "D";
                        break;
                    case 12:
                        sText = "Q";
                        _pile12[0] = sText + "S";
                        _pile12[1] = sText + "C";
                        _pile12[2] = sText + "H";
                        _pile12[3] = sText + "D";
                        break;
                    case 13:
                        sText = "K";
                        _pile13[0] = sText + "S";
                        _pile13[1] = sText + "C";
                        _pile13[2] = sText + "H";
                        _pile13[3] = sText + "D";
                        break;
                    default:
                        sText = Convert.ToString(i);
                        switch (i)
                        {
                            case 2:
                                _pile2[0] = sText + "S";
                                _pile2[1] = sText + "C";
                                _pile2[2] = sText + "H";
                                _pile2[3] = sText + "D";
                                break;
                            case 3:
                                _pile3[0] = sText + "S";
                                _pile3[1] = sText + "C";
                                _pile3[2] = sText + "H";
                                _pile3[3] = sText + "D";
                                break;
                            case 4:
                                _pile4[0] = sText + "S";
                                _pile4[1] = sText + "C";
                                _pile4[2] = sText + "H";
                                _pile4[3] = sText + "D";
                                break;
                            case 5:
                                _pile5[0] = sText + "S";
                                _pile5[1] = sText + "C";
                                _pile5[2] = sText + "H";
                                _pile5[3] = sText + "D";
                                break;
                            case 6:
                                _pile6[0] = sText + "S";
                                _pile6[1] = sText + "C";
                                _pile6[2] = sText + "H";
                                _pile6[3] = sText + "D";
                                break;
                            case 7:
                                _pile7[0] = sText + "S";
                                _pile7[1] = sText + "C";
                                _pile7[2] = sText + "H";
                                _pile7[3] = sText + "D";
                                break;
                            case 8:
                                _pile8[0] = sText + "S";
                                _pile8[1] = sText + "C";
                                _pile8[2] = sText + "H";
                                _pile8[3] = sText + "D";
                                break;
                            case 9:
                                _pile9[0] = sText + "S";
                                _pile9[1] = sText + "C";
                                _pile9[2] = sText + "H";
                                _pile9[3] = sText + "D";
                                break;
                        }

                        break;
                }
               
            }
        }

        private void fUpdateDisplay()
        {
            String sText,sWord,sBoard;

            if (lstBoard.Items.Count > 0)
            {
                do
                {
                    lstBoard.Items.RemoveAt(0);
                } while (lstBoard.Items.Count > 0);
            }
            if (lstPile.Items.Count > 0)
            {
                do
                {
                    lstPile.Items.RemoveAt(0);
                } while (lstPile.Items.Count > 0);
            }

            for (int i = 1; i <= 4; i++)
            {
                sText = null;
                for (int j = 1; j <= 8; j++)
                {
                    _board.fSet(i, j);
                    sBoard=_board.fRead();
                    switch (i)
                    {
                        case 1:
                            sWord = "[" + sBoard + "]";
                            break;
                        case 2:
                            sWord = "[" + sBoard + "]";
                            break;
                        case 3:
                            sWord = "[" + sBoard + "]";
                            break;
                        default:
                            sWord = "[" + sBoard + "]";
                            break;
                    }
                    sText = sText + sWord;
                }
                lstBoard.Items.Add(sText);
            }
            for (int i = 1; i <= 13; i++)
            {
                sText = null;
                for (int j = 1; j <= 4; j++)
                {
                    switch (i)
                    {
                        case 1:
                            sWord = "[" + _pile1[j - 1] + "]";
                            break;
                        case 2:
                            sWord = "[" + _pile2[j - 1] + "]";
                            break;
                        case 3:
                            sWord = "[" + _pile3[j - 1] + "]";
                            break;
                        case 4:
                            sWord = "[" + _pile4[j - 1] + "]";
                            break;
                        case 5:
                            sWord = "[" + _pile5[j - 1] + "]";
                            break;
                        case 6:
                            sWord = "[" + _pile6[j - 1] + "]";
                            break;
                        case 7:
                            sWord = "[" + _pile7[j - 1] + "]";
                            break;
                        case 8:
                            sWord = "[" + _pile8[j - 1] + "]";
                            break;
                        case 9:
                            sWord = "[" + _pile9[j - 1] + "]";
                            break;
                        case 10:
                            sWord = "[" + _pile10[j - 1] + "]";
                            break;
                        case 11:
                            sWord = "[" + _pile11[j - 1] + "]";
                            break;
                        case 12:
                            sWord = "[" + _pile12[j - 1] + "]";
                            break;
                        default:
                            sWord = "[" + _pile13[j - 1] + "]";
                            break;
                    }
                    sText = sText + sWord;
                }
                lstPile.Items.Add(sText);
            }
        }

        private void fUpdateDisplay2()
        {
            String sText, sWord, sBoard;

            if (lstBoard.Items.Count > 0)
            {
                do
                {
                    lstBoard.Items.RemoveAt(0);
                } while (lstBoard.Items.Count > 0);
            }
            for (int i = 1; i <= 4; i++)
            {
                sText = null;
                for (int j = 1; j <= 8; j++)
                {
                    _board.fSet(i, j);
                    sBoard = _board.fRead();
                    switch (i)
                    {
                        case 1:
                            sWord = "[" + sBoard + "]";
                            break;
                        case 2:
                            sWord = "[" + sBoard + "]";
                            break;
                        case 3:
                            sWord = "[" + sBoard + "]";
                            break;
                        default:
                            sWord = "[" + sBoard + "]";
                            break;
                    }
                    sText = sText + sWord;
                }
                lstBoard.Items.Add(sText);
            }

        }
        private int fCountpair(int nPile)
        {
            int nCount = 0;

            switch (nPile)
            {
                case 1:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile1[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile2[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile3[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile4[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 5:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile5[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 6:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile6[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 7:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile7[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 8:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile8[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 9:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile9[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 10:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile10[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 11:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile11[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                case 12:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile12[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
                default:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile13[i - 1] != null)
                        {
                            nCount += 1;
                        }
                    }
                    break;
            }
            nCount = nCount / 2;
            return nCount;
        }

        private String fFormword(int nPIle)
        {
            String sWord = null;

            switch (nPIle)
            {
                case 1:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile1[i - 1] != null)
                        {
                            sWord = sWord + _pile1[i - 1];
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile2[i - 1] != null)
                        {
                            sWord = sWord + _pile2[i - 1];
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile3[i - 1] != null)
                        {
                            sWord = sWord + _pile3[i - 1];
                        }
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile4[i - 1] != null)
                        {
                            sWord = sWord + _pile4[i - 1];
                        }
                    }
                    break;
                case 5:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile5[i - 1] != null)
                        {
                            sWord = sWord + _pile5[i - 1];
                        }
                    }
                    break;
                case 6:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile6[i - 1] != null)
                        {
                            sWord = sWord + _pile6[i - 1];
                        }
                    }
                    break;
                case 7:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile7[i - 1] != null)
                        {
                            sWord = sWord + _pile7[i - 1];
                        }
                    }
                    break;
                case 8:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile8[i - 1] != null)
                        {
                            sWord = sWord + _pile8[i - 1];
                        }
                    }
                    break;
                case 9:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile9[i - 1] != null)
                        {
                            sWord = sWord + _pile9[i - 1];
                        }
                    }
                    break;
                case 10:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile10[i - 1] != null)
                        {
                            sWord = sWord + _pile10[i - 1];
                        }
                    }
                    break;
                case 11:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile11[i - 1] != null)
                        {
                            sWord = sWord + _pile11[i - 1];
                        }
                    }
                    break;
                case 12:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile12[i - 1] != null)
                        {
                            sWord = sWord + _pile12[i - 1];
                        }
                    }
                    break;
                default:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile13[i - 1] != null)
                        {
                            sWord = sWord + _pile13[i - 1];
                        }
                    }
                    break;
            }
            return sWord;
        }
        private void fTNext()
        {
            Random rnd1 = new Random();
            String sPairs = null;
            String sWord;
            bool bFound = false;
            int nPile,nCount;
            int nLength,nPos1,nPos2;
            String sCard1, sCard2;
            int nCol = rnd1.Next(1, 5);
            int nRow = rnd1.Next(1, 9);

            for (int i = 1; i <= 13; i++)
            {
                sWord =Convert.ToString( fCountpair(i));
                sPairs = sPairs + sWord;
            }

            do
            {
                nPile = rnd1.Next(1, 14);
                nCount = Convert.ToInt32(sPairs.Substring(nPile - 1, 1));
                if (nCount != 0)
                {
                    bFound = true;
                }
            } while (bFound == false);

            sWord = fFormword(nPile);
            nLength = sWord.Length / 2;
            nPos1 = rnd1.Next(1, nLength + 1);
            sCard1 = sWord.Substring(nPos1 * 2 - 2, 2);
            fTake(nPile, sCard1);
            sWord = sWord.Substring(0, nPos1 * 2 - 2) + sWord.Substring(nPos1 * 2, (nLength - nPos1) * 2);
            nLength = sWord.Length / 2;
            nPos2 = rnd1.Next(1, nLength + 1);
            sCard2 = sWord.Substring(nPos2 * 2 - 2, 2);
            fTake(nPile, sCard2);
            //sWord = sWord.Substring(0, nPos2 * 2 - 2) + sWord.Substring(nPos2 * 2, (nLength - nPos2) * 2);

            fPlace(nCol, nRow, sCard1);
            nCol = rnd1.Next(1, 5);
            nRow = rnd1.Next(1, 9);
            fPlace(nCol, nRow, sCard2);

            fUpdateDisplay();
        }

        private void fPlace(int nCol,int nRow,String sCard)
        {
            _board.fSet(nCol,nRow);
            _board.fAdd(sCard);
        }
        private void fTake(int nPile,String sCard)
        {
            switch (nPile)
            {
                case 1:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile1[i - 1] == sCard)
                        {
                            _pile1[i - 1] = null;
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile2[i - 1] == sCard)
                        {
                            _pile2[i - 1] = null;
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile3[i - 1] == sCard)
                        {
                            _pile3[i - 1] = null;
                        }
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile4[i - 1] == sCard)
                        {
                            _pile4[i - 1] = null;
                        }
                    }
                    break;
                case 5:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile5[i - 1] == sCard)
                        {
                            _pile5[i - 1] = null;
                        }
                    }
                    break;
                case 6:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile6[i - 1] == sCard)
                        {
                            _pile6[i - 1] = null;
                        }
                    }
                    break;
                case 7:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile7[i - 1] == sCard)
                        {
                            _pile7[i - 1] = null;
                        }
                    }
                    break;
                case 8:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile8[i - 1] == sCard)
                        {
                            _pile8[i - 1] = null;
                        }
                    }
                    break;
                case 9:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile9[i - 1] == sCard)
                        {
                            _pile9[i - 1] = null;
                        }
                    }
                    break;
                case 10:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile10[i - 1] == sCard)
                        {
                            _pile10[i - 1] = null;
                        }
                    }
                    break;
                case 11:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile11[i - 1] == sCard)
                        {
                            _pile11[i - 1] = null;
                        }
                    }
                    break;
                case 12:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile12[i - 1] == sCard)
                        {
                            _pile12[i - 1] = null;
                        }
                    }
                    break;
                default:
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_pile13[i - 1] == sCard)
                        {
                            _pile13[i - 1] = null;
                        }
                    }
                    break;
            }
        }

        private void fCount()
        {
            String sText = null;
            int nCount;

            if (lstBoard2.Items.Count > 0)
            {
                do
                {
                    lstBoard2.Items.RemoveAt(0);
                } while (lstBoard2.Items.Count > 0);
            }

            sText = null;
            for (int i = 1; i <= 8; i++)
            {
                _board.fSet(1, i);
                nCount = _board.fReadCount();
                sText = sText + Convert.ToString(nCount);
            }
            lstBoard2.Items.Add(sText);
            sText = null;
            for (int i = 1; i <= 8; i++)
            {
                _board.fSet(2, i);
                nCount = _board.fReadCount();
                sText = sText + Convert.ToString(nCount);
            }
            lstBoard2.Items.Add(sText);
            sText = null;
            for (int i = 1; i <= 8; i++)
            {
                _board.fSet(3, i);
                nCount = _board.fReadCount();
                sText = sText + Convert.ToString(nCount);
            }
            lstBoard2.Items.Add(sText);
            sText = null;
            for (int i = 1; i <= 8; i++)
            {
                _board.fSet(4, i);
                nCount = _board.fReadCount();
                sText = sText + Convert.ToString(nCount);
            }
            lstBoard2.Items.Add(sText);
        }

        public fSub2()
        {
            InitializeComponent();
        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
        }

        private void btnTNext_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 26; i++)
            {
                fTNext();
            }
            fCount();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            String sText = null;

            if (txtRow.Text == null)
            {
                mnRow = 1;
            }
            else
            {
                mnRow = Convert.ToInt32(txtRow.Text);
                if (mnRow < 1)
                {
                    mnRow = 1;
                }
                if (mnRow > 8)
                {
                    mnRow = 8;
                }
            }

            _board.fSet(mnCol, mnRow);
            sText = _board.fReadAll();
            MessageBox.Show(sText, "Under " + Convert.ToString(mnCol) + Convert.ToString(mnRow));
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();

        }

        private void btnSecond_Click_1(object sender, EventArgs e)
        {
            String sText = null;

            if (txtRow.Text == null)
            {
                mnRow = 1;
            }
            else
            {
                mnRow = Convert.ToInt32(txtRow.Text);
                if (mnRow < 1)
                {
                    mnRow = 1;
                }
                if (mnRow > 8)
                {
                    mnRow = 8;
                }
            }

            _board.fSet(mnCol, mnRow);
            sText = _board.fRead();
            lblSecond.Text = sText;
            _second.fSet(mnCol, mnRow, sText);

        }

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            String sText = null;

            if (txtRow.Text == null)
            {
                mnRow = 1;
            }
            else
            {
                mnRow = Convert.ToInt32(txtRow.Text);
                if (mnRow < 1)
                {
                    mnRow = 1;
                }
                if (mnRow > 8)
                {
                    mnRow = 8;
                }
            }

            _board.fSet(mnCol, mnRow);
            sText = _board.fRead();
            lblFirst.Text = sText;
            _first.fSet(mnCol, mnRow, sText);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String sFirst = _first.fGet();
            String sSecond = _second.fGet();
            int nCol, nRow;

            if (sFirst == sSecond)
            {
                MessageBox.Show("Error!");
                return;
            }

            nCol = _first.fGetCol();
            nRow = _first.fGetRow();
            _board.fSet(nCol, nRow);
            _board.fPop();
            nCol = _second.fGetCol();
            nRow = _second.fGetRow();
            _board.fSet(nCol, nRow);
            _board.fPop();
            fUpdateDisplay2();
            fCount();
            lblFirst.Text = "Card";
            lblSecond.Text = "Card";
        }

        private void lstBoard_Click(object sender, EventArgs e)
        {
            mnCol = lstBoard.SelectedIndex + 1;
            fUpdateStatus();
        }

   
    }
}
