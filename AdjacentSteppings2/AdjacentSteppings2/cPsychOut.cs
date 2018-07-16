using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cPsychOut
    {
        public int fNumbers(int nLength,ref bool bTakeaction)
        {
            Random rnd1 = new Random();
            int nPos = rnd1.Next(1, nLength + 1);
            int nNumber = rnd1.Next(1, 10);

            if (nNumber <= 3)
            {
                bTakeaction = true;
            }
            else
            {
                bTakeaction = false;
            }
            return nPos;
        }
    }
}
