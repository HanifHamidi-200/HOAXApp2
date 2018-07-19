using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOAXManipulater
{
  
    class cMoveCode
    {
        private String msMovecode;
        private String msAddress;

        public void fInit()
        {
            msMovecode = null;
            msAddress = null;
        }
        
        public void fSet(String sMovecode)
        {
            msMovecode = sMovecode;
        }
        public String fGet()
        {
            return msMovecode;
        }

        public void fInit2(int nTryItem)
        {
            switch (nTryItem)
            {
                case 1:
                    msMovecode = "14";
                    msAddress = "CornerStart, try4";
                    break;
                case 2:
                    msMovecode = "12";
                    msAddress = "CornerStart, try2";
                    break;
                case 3:
                    msMovecode = "17";
                    msAddress = "CornerStart, try7";
                    break;
                case 4:
                    msMovecode = "13";
                    msAddress = "CornerStart, try3";
                    break;
                case 5:
                    msMovecode = "15";
                    msAddress = "CornerStart, try5";
                    break;
                case 6:
                    msMovecode = "18";
                    msAddress = "CornerStart, try8";
                    break;
                case 7:
                    msMovecode = "16";
                    msAddress = "CornerStart, try6";
                    break;
                case 8:
                    msMovecode = "19";
                    msAddress = "CornerStart, try9";
                    break;
                case 9:
                    msMovecode = "21";
                    msAddress = "EdgeStart, try1";
                    break;
                case 10:
                    msMovecode = "23";
                    msAddress = "EdgeStart, try3";
                    break;
                case 11:
                    msMovecode = "24";
                    msAddress = "EdgeStart, try4";
                    break;
                case 12:
                    msMovecode = "26";
                    msAddress = "EdgeStart, try6";
                    break;
                case 13:
                    msMovecode = "25";
                    msAddress = "EdgeStart, try5";
                    break;
                case 14:
                    msMovecode = "27";
                    msAddress = "EdgeStart, try7";
                    break;
                case 15:
                    msMovecode = "29";
                    msAddress = "EdgeStart, try9";
                    break;
                case 16:
                    msMovecode = "28";
                    msAddress = "EdgeStart, try8";
                    break;
                case 17:
                    msMovecode = "51";
                    msAddress = "CentreStart, try1";
                    break;
                case 18:
                    msMovecode = "57";
                    msAddress = "CentreStart, try7";
                    break;
                case 19:
                    msMovecode = "59";
                    msAddress = "CentreStart, try9";
                    break;
                case 20:
                    msMovecode = "53";
                    msAddress = "CentreStart, try3";
                    break;
                case 21:
                    msMovecode = "52";
                    msAddress = "CentreStart, try2";
                    break;
                case 22:
                    msMovecode = "54";
                    msAddress = "CentreStart, try4";
                    break;
                case 23:
                    msMovecode = "58";
                    msAddress = "CentreStart, try8";
                    break;
                case 24:
                    msMovecode = "56";
                    msAddress = "CentreStart, try6";
                    break;
            }
        }

        public String fPush(String sAdd,ref bool bError)
        {
            int nLength=msMovecode.Length;
            int nPos=0;
            bool bFound=false;
           
            if (msMovecode.Substring(nLength - 1, 1) != "0")
            {
                nPos = nLength+1;
                msMovecode = msMovecode + sAdd;
            }
            else
            {
                int i = 0;
                do
                {
                    i += 1;
                    if (msMovecode.Substring(i - 1, 1) == "0")
                    {
                        nPos = i;
                        bFound = true;
                    }

                } while (bFound == false);
                 if (nPos == 1)
                {
                    msMovecode = sAdd + msMovecode.Substring(nPos, 9 - nPos);
                }
                else
                {
                    msMovecode = msMovecode.Substring(0, nPos - 1) + sAdd + msMovecode.Substring(nPos, 9 - nPos);
                }
            }

            return msMovecode;
        }

        public String fPull(ref bool bError)
        {
            //undo
            int nLength = msMovecode.Length;

            if (nLength == 1)
            {
                bError = true;
                return null;
            }
            else
            {
                msMovecode = msMovecode.Substring(0, nLength - 1);
                bError = false;
                return msMovecode;
            }
        }
    }
}
