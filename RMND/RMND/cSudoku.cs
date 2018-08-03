using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMND
{
    class cSudoku
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _col9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnCol, mnRow;
    
        public void fSet(int nCol,int nRow,int nData)
        {
            mnCol = nCol;
            mnRow = nRow;
            switch (nCol)
            {
                case 1:
                    _col1[nRow - 1] = nData;
                    break;
                case 2:
                    _col2[nRow - 1] = nData;
                    break;
                case 3:
                    _col3[nRow - 1] = nData;
                    break;
                case 4:
                    _col4[nRow - 1] = nData;
                    break;
                case 5:
                    _col5[nRow - 1] = nData;
                    break;
                case 6:
                    _col6[nRow - 1] = nData;
                    break;
                case 7:
                    _col7[nRow - 1] = nData;
                    break;
                case 8:
                    _col8[nRow - 1] = nData;
                    break;
                default:
                    _col9[nRow - 1] = nData;
                    break;
            }
        }

        public void fSet2(int nCol,int nRow)
        {
            mnCol = nCol;
            mnRow = nRow;
        }

        public int fGet()
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
                case 8:
                    return _col8[mnRow - 1];
                default:
                    return _col9[mnRow - 1];
            }
        }
    }
}
