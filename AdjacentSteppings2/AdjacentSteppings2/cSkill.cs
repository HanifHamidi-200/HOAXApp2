using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cSkill
    {
        private bool bOn;

        public void fInitskill()
        {
            bOn = false;
        }
        public void fSetskill()
        {
            bOn = true;
        }
        private bool fGetskill()
        {
            return bOn;
        }
    }
}
