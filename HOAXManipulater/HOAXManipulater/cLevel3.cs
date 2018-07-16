using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOAXManipulater
{
    class cLevel3
    {
        private int nNumber;

        public String fAny(String s1,String s2)
        {
            Random rnd1 = new Random();
            nNumber = rnd1.Next(1, 10);

            if (nNumber <=5)
            {
                return s1;
            }
            else
            {
                return s2;
            }
        }

        public int fResponse(int nTryItem)
        {
            int nAnswer;
            String sExamine;
         
            switch (nTryItem)
            {
                case 1:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 2:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 3:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 4:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 5:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 6:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 7:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 8:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 9:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 10:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 11:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 12:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 13:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 14:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 15:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 16:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                case 17:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
                default:
                    sExamine = fAny("143", "145");
                    nAnswer = Convert.ToInt32(sExamine.Substring(2, 1));
                    return nAnswer;
            }
        }

    }
}
