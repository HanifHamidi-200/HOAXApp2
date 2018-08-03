using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMND
{
    class cBoard
    {
        private List<String> _board1 = new List<String> { null, null, null, null, null, null, null, null };
        private List<String> _board2 = new List<String> { null, null, null, null, null, null, null, null };
        private List<String> _board3 = new List<String> { null, null, null, null, null, null, null, null };
        private List<String> _board4 = new List<String> { null, null, null, null, null, null, null, null };
        private int mnCol, mnRow;



        public void fSet(int nCol,int nRow)
        {
            mnCol = nCol;
            mnRow = nRow;
        }

        public int fGetCol()
        {
            return mnCol;
        }
        public int fGetRow()
        {
            return mnRow;
        }

        public void fInit()
        {
            switch (mnCol)
            {
                case 1:
                    _board1[mnRow - 1] = null;
                    break;
                case 2:
                    _board2[mnRow - 1] = null;
                    break;
                case 3:
                    _board3[mnRow - 1] = null;
                    break;
                default:
                    _board4[mnRow - 1] = null;
                    break;
            }

        }

        public void fAdd(String sCard)
        {
            switch (mnCol)
            {
                case 1:
                    _board1[mnRow - 1] = _board1[mnRow - 1] + sCard;
                    break;
                case 2:
                    _board2[mnRow - 1] = _board2[mnRow - 1] + sCard;
                    break;
                case 3:
                    _board3[mnRow - 1] = _board3[mnRow - 1] + sCard;
                    break;
                default:
                    _board4[mnRow - 1] = _board4[mnRow - 1] + sCard;
                    break;
            }

        }

        public String fRead()
        {
            int nLength;

            switch (mnCol)
            {
                case 1:
                    if (_board1[mnRow - 1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        nLength = _board1[mnRow - 1].Length/2;
                        if (nLength == 0)
                        {
                            return null;
                        }
                        return _board1[mnRow - 1].Substring((nLength - 1) * 2, 2);
                    }                   
                case 2:
                    if (_board2[mnRow - 1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        nLength = _board2[mnRow - 1].Length/2;
                        if (nLength == 0)
                        {
                            return null;
                        }
                        return _board2[mnRow - 1].Substring((nLength - 1) * 2, 2);
                    }
                case 3:
                    if (_board3[mnRow - 1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        nLength = _board3[mnRow - 1].Length/2;
                        if (nLength == 0)
                        {
                            return null;
                        }
                        return _board3[mnRow - 1].Substring((nLength - 1) * 2, 2);
                    }
                default:
                    if (_board4[mnRow - 1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        nLength = _board4[mnRow - 1].Length/2;
                        if (nLength == 0)
                        {
                            return null;
                        }
                        return _board4[mnRow - 1].Substring((nLength - 1) * 2, 2);
                    }
            }
        }

        public void fPop()
        {
            int nLength;
            String sText;

            switch (mnCol)
            {
                case 1:
                    if (_board1[mnRow - 1] == null)
                    {
                        return ;
                    }
                    else
                    {
                        sText = _board1[mnRow - 1];
                        nLength = _board1[mnRow - 1].Length / 2;
                        _board1[mnRow - 1] = sText.Substring(0, (nLength - 1) * 2);
                        return;
                    }
                case 2:
                    if (_board2[mnRow - 1] == null)
                    {
                        return ;
                    }
                    else
                    {
                        sText = _board2[mnRow - 1];
                        nLength = _board2[mnRow - 1].Length / 2;
                        _board2[mnRow - 1] = sText.Substring(0, (nLength - 1) * 2);
                        return;
                    }
                case 3:
                    if (_board3[mnRow - 1] == null)
                    {
                        return ;
                    }
                    else
                    {
                        sText = _board3[mnRow - 1];
                        nLength = _board3[mnRow - 1].Length / 2;
                        _board3[mnRow - 1] = sText.Substring(0, (nLength - 1) * 2);
                        return;
                    }
                default:
                    if (_board4[mnRow - 1] == null)
                    {
                        return ;
                    }
                    else
                    {
                        sText = _board4[mnRow - 1];
                        nLength = _board4[mnRow - 1].Length / 2;
                        _board4[mnRow - 1] = sText.Substring(0, (nLength - 1) * 2);
                        return;
                    }
            }
        }
        public int fReadCount()
        {
            int nLength;

            switch (mnCol)
            {
                case 1:
                    if (_board1[mnRow - 1] == null)
                    {
                        return 0;
                    }
                    else
                    {
                        nLength = _board1[mnRow - 1].Length / 2;
                        return nLength;
                    }
                case 2:
                    if (_board2[mnRow - 1] == null)
                    {
                        return 0;
                    }
                    else
                    {
                        nLength = _board2[mnRow - 1].Length / 2;
                        return nLength;
                    }
                case 3:
                    if (_board3[mnRow - 1] == null)
                    {
                        return 0;
                    }
                    else
                    {
                        nLength = _board3[mnRow - 1].Length / 2;
                        return nLength;
                    }
                default:
                    if (_board4[mnRow - 1] == null)
                    {
                        return 0;
                    }
                    else
                    {
                        nLength = _board4[mnRow - 1].Length / 2;
                        return nLength;
                    }
            }
        }

        public String fReadAll()
        {
            int nLength;
            String sText = null;

            switch (mnCol)
            {
                case 1:
                    if (_board1[mnRow - 1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        nLength = _board1[mnRow - 1].Length / 2;
                        for (int i = nLength; i >= 1; i--)
                        {
                            sText= sText+_board1[mnRow - 1].Substring((i - 1) * 2, 2);
                        }
                        return sText;
                    }
                case 2:
                    if (_board2[mnRow - 1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        nLength = _board2[mnRow - 1].Length / 2;
                        for (int i = nLength; i >= 1; i--)
                        {
                            sText = sText + _board2[mnRow - 1].Substring((i - 1) * 2, 2);
                        }
                        return sText;
                    }
                case 3:
                    if (_board3[mnRow - 1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        nLength = _board3[mnRow - 1].Length / 2;
                        return _board3[mnRow - 1].Substring((nLength - 1) * 2, 2);
                        for (int i = nLength; i >= 1; i--)
                        {
                            sText = sText + _board3[mnRow - 1].Substring((i - 1) * 2, 2);
                        }
                        return sText;
                    }
                default:
                    if (_board4[mnRow - 1] == null)
                    {
                        return null;
                    }
                    else
                    {
                        nLength = _board4[mnRow - 1].Length / 2;
                        for (int i = nLength; i >= 1; i--)
                        {
                            sText = sText + _board4[mnRow - 1].Substring((i - 1) * 2, 2);
                        }
                        return sText;
                    }
            }
        }
    }
}
