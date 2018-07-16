using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOAXManipulater
{
    class cStringCode
    {
        private String msStringcode;

        public void fInit()
        {
            msStringcode = "000000000";
        }

        public void fInit2(int nTryItem)
        {
            switch (nTryItem)
            {
                case 1:
                    msStringcode = "100200000";
                    break;
                case 2:
                    msStringcode = "120000000";
                    break;
                case 3:
                    msStringcode = "100000200";
                    break;
                case 4:
                    msStringcode = "102000000";
                    break;
                case 5:
                    msStringcode = "100020000";
                    break;
                case 6:
                    msStringcode = "100000020";
                    break;
                case 7:
                    msStringcode = "100002000";
                    break;
                case 8:
                    msStringcode = "100000002";
                    break;
                case 9:
                    msStringcode = "210000000";
                    break;
                case 10:
                    msStringcode = "012000000";
                    break;
                case 11:
                    msStringcode = "010200000";
                    break;
                case 12:
                    msStringcode = "010002000";
                    break;
                case 13:
                    msStringcode = "010020000";
                    break;
                case 14:
                    msStringcode = "010000200";
                    break;
                case 15:
                    msStringcode = "010000002";
                    break;
                case 16:
                    msStringcode = "010000020";
                    break;
                case 17:
                    msStringcode = "200010000";
                    break;
                case 18:
                    msStringcode = "000010200";
                    break;
                case 19:
                    msStringcode = "000010002";
                    break;
                case 20:
                    msStringcode = "002010000";
                    break;
                case 21:
                    msStringcode = "020010000";
                    break;
                case 22:
                    msStringcode = "000210000";
                    break;
                case 23:
                    msStringcode = "000010020";
                    break;
                default:
                    msStringcode = "000012000";
                    break;
            }
        }

        public String fGet()
        {
            return msStringcode;
        }

        public String fPush(String sAdd, int nPos,ref bool bError)
        {
            String sVacant = msStringcode.Substring(nPos - 1,1);

            if (sVacant == "0")
            {
                bError = false;
                msStringcode = msStringcode.Substring(0, nPos - 1) + sAdd + msStringcode.Substring(nPos, 9 - nPos);
                return msStringcode;
            }
            else
            {
                bError = true;
                return null;
            }

        }
        public String fPull(ref String sPull, int nPos, ref bool bError)
        {
            sPull = msStringcode.Substring(nPos - 1);

            if (sPull == "0")
            {
                bError = true;
                return null;
               }
            else
            {
                bError = false;
                msStringcode = msStringcode.Substring(0, nPos - 1) + "0" + msStringcode.Substring(nPos, 9 - nPos);
                return msStringcode;
            }

        }
    }
}