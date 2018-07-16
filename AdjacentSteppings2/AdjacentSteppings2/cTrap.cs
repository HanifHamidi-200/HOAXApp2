using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cTrap
    {
        public void fTrap(int nLevel, ref int nHP, ref bool bDead)
        {
            Random rnd1 = new Random();
            int nTake = rnd1.Next(10, 27);

            if (nLevel > 1)
            {
                nTake = nTake * nLevel;
            }
            if (nTake > nHP)
            {
                nTake = nHP;
            }
            nHP -= nTake;
            if (nHP == 0)
            {
                bDead = true;
            }
            else
            {
                bDead = false;
            }
        }
    }
}
