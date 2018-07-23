using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cBoard
    {
        //Board8x30
        private  List<int> _Design1_1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1_2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1_3= new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1_4= new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1_5= new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1_6= new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1_7= new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1_8=new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1r_1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1r_2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1r_3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1r_4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1r_5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1r_6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1r_7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _Design1r_8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_10 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_11 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_12 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_13 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_14 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_15 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_16 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_17 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_18 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_19 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_20 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_21 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_22 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_23 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_24 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_25 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_26 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_27 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_28 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_29 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2_30 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_10 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_11 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_12 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_13 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_14 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_15 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_16 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_17 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_18 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_19 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_20 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_21 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_22 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_23 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_24 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_25 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_26 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_27 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_28 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_29 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _Design2r_30 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };

        private int mnCol, mnRow,mnWait,mnRotate;

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
            Random rnd1 = new Random();
            int nNumber = rnd1.Next(1, 10);

            mnWait = nType;
            if (mnWait == 1)
            {
                if (nNumber <= 5)
                {
                    mnWait = 2;
                }
            }
        }
        public void fSetRotate(int nType)
        {
            mnRotate =nType;
        }

        public int fReadType()
        {
            switch (mnCol)
            {
                case 1:
                    return _Design1_1[mnRow - 1];
                case 2:
                    return _Design1_2[mnRow - 1];
                case 3:
                    return _Design1_3[mnRow - 1];
                case 4:
                    return _Design1_4[mnRow - 1];
                case 5:
                    return _Design1_5[mnRow - 1];
                case 6:
                    return _Design1_6[mnRow - 1];
                case 7:
                    return _Design1_7[mnRow - 1];
                default:
                    return _Design1_8[mnRow - 1];
            }
        }
        public int fReadRotate()
        {
            switch (mnCol)
            {
                case 1:
                    return _Design1r_1[mnRow - 1];
                case 2:
                    return _Design1r_2[mnRow - 1];
                case 3:
                    return _Design1r_3[mnRow - 1];
                case 4:
                    return _Design1r_4[mnRow - 1];
                case 5:
                    return _Design1r_5[mnRow - 1];
                case 6:
                    return _Design1r_6[mnRow - 1];
                case 7:
                    return _Design1r_7[mnRow - 1];
                default:
                    return _Design1r_8[mnRow - 1];
            }
        }

        public void fWrite()
        {
            switch (mnCol)
            {
                case 1:
                    _Design1_1[mnRow - 1] = mnWait;
                    _Design1r_1[mnRow - 1] = mnRotate;
                    break;
                case 2:
                    _Design1_2[mnRow - 1] = mnWait;
                    _Design1r_2[mnRow - 1] = mnRotate;
                    break;
                case 3:
                    _Design1_3[mnRow - 1] = mnWait;
                    _Design1r_3[mnRow - 1] = mnRotate;
                    break;
                case 4:
                    _Design1_4[mnRow - 1] = mnWait;
                    _Design1r_4[mnRow - 1] = mnRotate;
                    break;
                case 5:
                    _Design1_5[mnRow - 1] = mnWait;
                    _Design1r_5[mnRow - 1] = mnRotate;
                    break;
                case 6:
                    _Design1_6[mnRow - 1] = mnWait;
                    _Design1r_6[mnRow - 1] = mnRotate;
                    break;
                case 7:
                    _Design1_7[mnRow - 1] = mnWait;
                    _Design1r_7[mnRow - 1] = mnRotate;
                    break;
                default:
                    _Design1_8[mnRow - 1] = mnWait;
                    _Design1r_8[mnRow - 1] = mnRotate;
                    break;
            }

        }
    }
}
