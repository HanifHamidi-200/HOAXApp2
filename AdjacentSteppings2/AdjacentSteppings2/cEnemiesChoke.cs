using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cEnemiesChoke
    {
        public void fChoke(int  nLevel, ref int nHP, ref bool bDead)
        {
            Random rnd1 = new Random();
            int nTake = rnd1.Next(8, 17);

            if (nLevel>1)
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
