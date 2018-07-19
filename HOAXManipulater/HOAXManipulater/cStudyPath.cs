using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOAXManipulater
{
 
    class cStudyPath
    {
        private int mnItem,mnRotate;
        private String msMoveCode, msMoveCode2,msStringCode, msStringCode2;

        public void fSet(int nItem,int nRotate)
        {
            mnItem = nItem;
            mnRotate = nRotate;
        }

        public int fGetItem()
        {
            return mnItem;
        }
        public int fGetRotate()
        {
            return mnRotate;
        }

        public String fTranscribe4()
        {
            String sNew = "000000000";
            String sLetter;
            int nPos, nNewPos;

            switch (mnRotate)
            {
                case 1:
                    return msStringCode;
                case 2:
                    for (int i = 1; i <= 9; i++)
                    {
                        sLetter = msStringCode.Substring(i - 1, 1);
                        if (sLetter != "0")
                        {
                            switch (i)
                            {
                                case 1:
                                    nNewPos = 7;
                                    break;
                                case 2:
                                    nNewPos = 4;
                                    break;
                                case 3:
                                    nNewPos = 1;
                                    break;
                                case 4:
                                    nNewPos = 8;
                                    break;
                                case 5:
                                    nNewPos = 5;
                                    break;
                                case 6:
                                    nNewPos = 2;
                                    break;
                                case 7:
                                    nNewPos = 9;
                                    break;
                                case 8:
                                    nNewPos = 6;
                                    break;
                                default:
                                    nNewPos = 3;
                                    break;

                            }
                            if (nNewPos == 1)
                            {
                                sNew = sLetter + sNew.Substring(nNewPos, 9 - nNewPos);
                            }
                            else
                            {
                                sNew = sNew.Substring(0, nNewPos - 1) + sLetter + sNew.Substring(nNewPos, 9 - nNewPos);
                            }
                            

                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 9; i++)
                    {
                        sLetter = msStringCode.Substring(i - 1, 1);
                        if (sLetter != "0")
                        {
                            switch (i)
                            {
                                case 1:
                                    nNewPos = 9;
                                    break;
                                case 2:
                                    nNewPos = 9;
                                    break;
                                case 3:
                                    nNewPos = 7;
                                    break;
                                case 4:
                                    nNewPos = 6;
                                    break;
                                case 5:
                                    nNewPos = 5;
                                    break;
                                case 6:
                                    nNewPos = 4;
                                    break;
                                case 7:
                                    nNewPos = 3;
                                    break;
                                case 8:
                                    nNewPos = 2;
                                    break;
                                default:
                                    nNewPos = 1;
                                    break;

                            }
                            if (nNewPos == 1)
                            {
                                sNew = sLetter + sNew.Substring(nNewPos, 9 - nNewPos);
                            }
                            else
                            {
                                sNew = sNew.Substring(0, nNewPos - 1) + sLetter + sNew.Substring(nNewPos, 9 - nNewPos);
                            }


                        }
                    }
                    break;

                default:
                    for (int i = 1; i <= 9; i++)
                    {
                        sLetter = msStringCode.Substring(i - 1, 1);
                        if (sLetter != "0")
                        {
                            switch (i)
                            {
                                case 1:
                                    nNewPos = 3;
                                    break;
                                case 2:
                                    nNewPos = 6;
                                    break;
                                case 3:
                                    nNewPos = 9;
                                    break;
                                case 4:
                                    nNewPos = 2;
                                    break;
                                case 5:
                                    nNewPos = 5;
                                    break;
                                case 6:
                                    nNewPos = 8;
                                    break;
                                case 7:
                                    nNewPos = 1;
                                    break;
                                case 8:
                                    nNewPos = 4;
                                    break;
                                default:
                                    nNewPos = 7;
                                    break;

                            }
                            if (nNewPos == 1)
                            {
                                sNew = sLetter + sNew.Substring(nNewPos, 9 - nNewPos);
                            }
                            else
                            {
                                sNew = sNew.Substring(0, nNewPos - 1) + sLetter + sNew.Substring(nNewPos, 9 - nNewPos);
                            }


                        }
                    }
                    break;
            }

            msStringCode2 = sNew;
            return sNew;
        }

        public String fTranscribe3()
        {
            switch (msMoveCode)
            {
                case "140000000":
                    msStringCode= "100200000";
                    break;
                case "120000000":
                    msStringCode= "120000000";
                    break;
                case "170000000":
                    msStringCode= "100000200";
                    break;
                case "130000000":
                    msStringCode= "102000000";
                    break;
                case "150000000":
                    msStringCode= "100020000";
                    break;
                case "180000000":
                    msStringCode= "100000020";
                    break;
                case "160000000":
                    msStringCode= "100002000";
                    break;
                case "190000000":
                    msStringCode= "100000002";
                    break;
                case "210000000":
                    msStringCode= "210000000";
                    break;
                case "230000000":
                    msStringCode= "012000000";
                    break;
                case "240000000":
                    msStringCode= "010200000";
                    break;
                case "260000000":
                    msStringCode= "010002000";
                    break;
                case "250000000":
                    msStringCode= "010020000";
                    break;
                case "270000000":
                    msStringCode= "010000200";
                    break;
                case "290000000":
                    msStringCode= "010000002";
                    break;
                case "280000000":
                    msStringCode= "010000020";
                    break;
                case "510000000":
                    msStringCode= "200010000";
                    break;
                case "570000000":
                    msStringCode= "000010200";
                    break;
                case "590000000":
                    msStringCode= "000010002";
                    break;
                case "530000000":
                    msStringCode= "002010000";
                    break;
                case "520000000":
                    msStringCode= "020010000";
                    break;
                case "540000000":
                    msStringCode= "000210000";
                    break;
                case "580000000":
                    msStringCode= "000010020";
                    break;
                default:
                    msStringCode= "000012000";
                    break;
            }
            return msStringCode;
        }
        public String fTranscribe2(String sMoveCode)
        {
            String sNew = "000000000";
            String sLetter;
            int nPos,nNewPos;
            int nTurn = 1;

            switch (mnRotate)
            {
                case 1:
                    return sMoveCode;
                case 2:
                    for (int i = 1; i <= 9; i++)
                    {
                        sLetter = sMoveCode.Substring(i - 1, 1);
                        nPos = Convert.ToInt32(sLetter);
                        switch (nPos)
                        {
                            case 0:
                                nNewPos = 0;
                                break;
                            case 1:
                                nNewPos = 7;
                                break;
                            case 2:
                                nNewPos = 4;
                                break;
                            case 3:
                                nNewPos = 1;
                                break;
                            case 4:
                                nNewPos = 8;
                                break;
                            case 5:
                                nNewPos = 5;
                                break;
                            case 6:
                                nNewPos = 2;
                                break;
                            case 7:
                                nNewPos = 9;
                                break;
                            case 8:
                                nNewPos = 6;
                                break;
                            default:
                                nNewPos = 3;
                                break;

                        }
                        if (nNewPos != 0)
                        {


                            if (i == 1)
                            {
                                sNew = Convert.ToString(nNewPos) + sNew.Substring(i, 9 - i);
                            }
                            else
                            {
                                sNew = sNew.Substring(0, i - 1) + Convert.ToString(nNewPos) + sNew.Substring(i, 9 - i);
                            }
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 9; i++)
                    {
                        sLetter = sMoveCode.Substring(i - 1, 1);
                        nPos = Convert.ToInt32(sLetter);
                        switch (nPos)
                        {
                            case 0:
                                nNewPos = 0;
                                break;
                            case 1:
                                nNewPos = 9;
                                break;
                            case 2:
                                nNewPos = 8;
                                break;
                            case 3:
                                nNewPos = 7;
                                break;
                            case 4:
                                nNewPos = 6;
                                break;
                            case 5:
                                nNewPos = 5;
                                break;
                            case 6:
                                nNewPos = 4;
                                break;
                            case 7:
                                nNewPos = 3;
                                break;
                            case 8:
                                nNewPos = 2;
                                break;
                            default:
                                nNewPos = 1;
                                break;

                        }
                        if (nNewPos != 0)
                        {


                            if (i == 1)
                            {
                                sNew = Convert.ToString(nNewPos) + sNew.Substring(i, 9 - i);
                            }
                            else
                            {
                                sNew = sNew.Substring(0, i - 1) + Convert.ToString(nNewPos) + sNew.Substring(i, 9 - i);
                            }
                        }
                    }
                    break;
                default:
                    for (int i = 1; i <= 9; i++)
                    {
                        sLetter = sMoveCode.Substring(i - 1, 1);
                        nPos = Convert.ToInt32(sLetter);
                        switch (nPos)
                        {
                            case 0:
                                nNewPos = 0;
                                break;
                            case 1:
                                nNewPos = 3;
                                break;
                            case 2:
                                nNewPos = 6;
                                break;
                            case 3:
                                nNewPos = 9;
                                break;
                            case 4:
                                nNewPos = 2;
                                break;
                            case 5:
                                nNewPos = 5;
                                break;
                            case 6:
                                nNewPos = 8;
                                break;
                            case 7:
                                nNewPos = 1;
                                break;
                            case 8:
                                nNewPos = 4;
                                break;
                            default:
                                nNewPos = 7;
                                break;

                        }
                        if (nNewPos != 0)
                        {


                            if (i == 1)
                            {
                                sNew = Convert.ToString(nNewPos) + sNew.Substring(i, 9 - i);
                            }
                            else
                            {
                                sNew = sNew.Substring(0, i - 1) + Convert.ToString(nNewPos) + sNew.Substring(i, 9 - i);
                            }
                        }
                    }
                    break;
            }
            msMoveCode2 = sNew;
           return sNew;
        }

        public String fTranscribe1()
        {
            switch(mnItem)
            {
                case 1:
                    msMoveCode= "140000000";
                    break;
                case 2:
                    msMoveCode = "120000000";
                    break;
                case 3:
                    msMoveCode = "170000000";
                    break;
                case 4:
                    msMoveCode = "130000000";
                    break;
                case 5:
                    msMoveCode = "150000000";
                    break;
                case 6:
                    msMoveCode = "180000000";
                    break;
                case 7:
                    msMoveCode = "160000000";
                    break;
                case 8:
                    msMoveCode = "190000000";
                    break;
                case 9:
                    msMoveCode = "210000000";
                    break;
                case 10:
                    msMoveCode = "230000000";
                    break;
                case 11:
                    msMoveCode = "240000000";
                    break;
                case 12:
                    msMoveCode = "260000000";
                    break;
                case 13:
                    msMoveCode = "250000000";
                    break;
                case 14:
                    msMoveCode = "270000000";
                    break;
                case 15:
                    msMoveCode = "290000000";
                    break;
                case 16:
                    msMoveCode = "280000000";
                    break;
                case 17:
                    msMoveCode = "510000000";
                    break;
                case 18:
                    msMoveCode = "570000000";
                    break;
                case 19:
                    msMoveCode = "590000000";
                    break;
                case 20:
                    msMoveCode = "530000000";
                    break;
                case 21:
                    msMoveCode = "520000000";
                    break;
                case 22:
                    msMoveCode = "540000000";
                    break;
                case 23:
                    msMoveCode = "580000000";
                    break;
                default:
                    msMoveCode = "560000000";
                    break;
            }
            return msMoveCode;
        }

    }
}
