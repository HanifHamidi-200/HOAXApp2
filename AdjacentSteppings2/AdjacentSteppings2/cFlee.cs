using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cFlee
    {
        public bool bSuccess(bool bBush)
        {
            Random rnd1 = new Random();
            int nNumber = rnd1.Next(1, 10);

            if (bBush)
            {
                if (nNumber <= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
