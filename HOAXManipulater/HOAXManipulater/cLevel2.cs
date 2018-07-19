using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOAXManipulater
{ 
    class cLevel2
    {
        public String fAnyOrder(String s1,int nPos)
        {
            switch (nPos)
            {
                case 1:
                    return s1;
                case 2:
                    return s1.Substring(1,2)+s1.Substring(0,1);
                default:
                    return s1.Substring(2,1)+s1.Substring(0,2);
            }
        }

        public String fPeek(String sStringCode,int nPos)
        {
            return sStringCode.Substring(nPos - 1);
        }

        public int fParse(String s1,String s2,String s3,String sExamine)
        {
            if (s1 == "1")
            {
                if (s2 == "1")
                {
                    if (s3 == "0")
                    {
                        return Convert.ToInt32(sExamine.Substring(2, 1));
                    }
                }
            }
            if (s1 == "1")
            {
                if (s3 == "1")
                {
                    if (s2 == "0")
                    {
                        return Convert.ToInt32(sExamine.Substring(1, 1));
                    }
                }
            }
            if (s2 == "1")
            {
                if (s3 == "1")
                {
                    if (s1 == "0")
                    {
                        return Convert.ToInt32(sExamine.Substring(0, 1));
                    }
                }
            }
            if (s1 == "2")
            {
                if (s2 == "2")
                {
                    if (s3 == "0")
                    {
                        return Convert.ToInt32(sExamine.Substring(2, 1));
                    }
                }
            }
            if (s1 == "2")
            {
                if (s3 == "2")
                {
                    if (s2 == "0")
                    {
                        return Convert.ToInt32(sExamine.Substring(1, 1));
                    }
                }
            }
            if (s2 == "2")
            {
                if (s3 == "2")
                {
                    if (s1 == "0")
                    {
                        return Convert.ToInt32(sExamine.Substring(0, 1));
                    }
                }
            }
            return 0;
        }
        public int fResponse(String sStringCode)
        {
            int nPuzzle,nAnswer;
            String sExamine;
            String sPeek1,sPeek2,sPeek3;

            nPuzzle = 1;
             do
            {
                    switch (nPuzzle)
                    {
                        case 1:
                            sExamine = "147";
                            break;
                        case 2:
                            sExamine = "258";
                            break;
                        case 3:
                            sExamine = "369";
                            break;
                        case 4:
                            sExamine = "123";
                            break;
                        case 5:
                            sExamine = "456";
                            break;
                        case 6:
                            sExamine = "789";
                            break;
                        case 7:
                            sExamine = "159";
                            break;
                        default:
                            sExamine = "357";
                            break;
                    }
                    sPeek1 = fPeek(sStringCode, Convert.ToInt32(sExamine.Substring(0,1)));
                    sPeek2 = fPeek(sStringCode, Convert.ToInt32(sExamine.Substring(1, 1)));
                    sPeek3 = fPeek(sStringCode, Convert.ToInt32(sExamine.Substring(2, 1)));
                    nAnswer = fParse(sPeek1, sPeek2, sPeek3, sExamine);
                if (nAnswer != 0)
                {
                    return nAnswer;

                }
                nPuzzle +=1;
              
            } while (nPuzzle <=8);

            return 0;
        }
    }
}
