using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UPMOL
{
    class cFloat
    {
        private int mnCol, mnRow;
        private bool mbVisible;

        public void fSetVisible(bool bVisible)
        {
            mbVisible = bVisible;
        }
        public void fSet(int nCol, int nRow)
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

        public bool fGetVisible()
        {
            return mbVisible;
        }
    }
}