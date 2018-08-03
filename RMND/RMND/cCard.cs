using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMND
{
    
    class cCard
    {
        private int mnCol, mnRow;
        private String msCard;

        public void fSet(int nCol,int nRow,String sCard)
        {
            mnCol = nCol;
            mnRow = nRow;
            msCard = sCard;
        }
        public void fSet2(int nCol, int nRow)
        {
            mnCol = nCol;
            mnRow = nRow;
        }

        public String fGet()
        {
            return msCard;
        }
        public int fGetCol()
        {
            return mnCol;
        }
        public int fGetRow()
        {
            return mnRow;
        }
    }
}
