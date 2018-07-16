using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cDisplay
    {
    private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0};
    private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
    private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
    private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
    private static List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
    private static List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
    private static List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
    private static List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };

        private int mnCol, mnRow, mnWait,mnRotate;

    public void fSetcol(int nCol)
    {
        mnCol = nCol;
    }
    public void fSetrow(int nRow)
    {
        mnRow = nRow;
    }
    public void fSetwait(int nType)
    {
        mnWait = nType;
    }
    public void fSetRotate(int nType)
     {
        mnRotate = nType;
     }

        public int fRead()
    {
        switch (mnCol)
        {
            case 1:
                return _col1[mnRow - 1];
            case 2:
                return _col2[mnRow - 1];
            case 3:
                return _col3[mnRow - 1];
            case 4:
                return _col4[mnRow - 1];
            case 5:
                return _col5[mnRow - 1];
            case 6:
                return _col6[mnRow - 1];
            case 7:
                return _col7[mnRow - 1];
            default:
                return _col8[mnRow - 1];
        }
    }

        public int fReadType()
        {
            switch (mnCol)
            {
                case 1:
                    return _col1[mnRow - 1];
                case 2:
                    return _col2[mnRow - 1];
                case 3:
                    return _col3[mnRow - 1];
                case 4:
                    return _col4[mnRow - 1];
                case 5:
                    return _col5[mnRow - 1];
                case 6:
                    return _col6[mnRow - 1];
                case 7:
                    return _col7[mnRow - 1];
                default:
                    return _col8[mnRow - 1];
            }
        }
        public int fReadRotate()
        {
            switch (mnCol)
            {
                case 1:
                    return _rotate1[mnRow - 1];
                case 2:
                    return _rotate2[mnRow - 1];
                case 3:
                    return _rotate3[mnRow - 1];
                case 4:
                    return _rotate4[mnRow - 1];
                case 5:
                    return _rotate5[mnRow - 1];
                case 6:
                    return _rotate6[mnRow - 1];
                case 7:
                    return _rotate7[mnRow - 1];
                default:
                    return _rotate8[mnRow - 1];
            }
        }

        public void fWrite()
        {
            switch (mnCol)
            {
                case 1:
                    _col1[mnRow - 1] = mnWait;
                    _rotate1[mnRow - 1] = mnRotate;
                    break;
                case 2:
                    _col2[mnRow - 1] = mnWait;
                    _rotate2[mnRow - 1] = mnRotate;
                    break;
                case 3:
                    _col3[mnRow - 1] = mnWait;
                    _rotate3[mnRow - 1] = mnRotate;
                    break;
                case 4:
                    _col4[mnRow - 1] = mnWait;
                    _rotate4[mnRow - 1] = mnRotate;
                    break;
                case 5:
                    _col5[mnRow - 1] = mnWait;
                    _rotate5[mnRow - 1] = mnRotate;
                    break;
                case 6:
                    _col6[mnRow - 1] = mnWait;
                    _rotate6[mnRow - 1] = mnRotate;
                    break;
                case 7:
                    _col7[mnRow - 1] = mnWait;
                    _rotate7[mnRow - 1] = mnRotate;
                    break;
                default:
                    _col8[mnRow - 1] = mnWait;
                    _rotate8[mnRow - 1] = mnRotate;
                    break;
            }

        }
    }

}
