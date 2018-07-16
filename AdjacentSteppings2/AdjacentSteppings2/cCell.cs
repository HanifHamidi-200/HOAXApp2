using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    
    public class cCell
    {
        int mnCol, mnRow,mnRotate,mnHP;
        bool mbSkill, mbDead;

        public void fSetcol(int nCol)
        {
            mnCol = nCol;
        }
        public void fSetrow(int nRow)
        {
            mnRow = nRow;
        }
        public void fSetrotate(int nRotate)
        {
            mnRotate = nRotate;
        }
        public void fSetHP(int nValue)
        {
            mnHP = nValue;
        }
        public void fSetSkill(bool bValue)
        {
            mbSkill = bValue;
        }
        public void fSetDead(bool bValue)
        {
            mbDead = bValue;
        }

        public int fGetcol()
        {
            return mnCol;
        }
        public int fGetrow()
        {
            return mnRow;
        }
        public int fGetrotate()
        {
            return mnRotate;
        }
        public int fGetHP()
        {
            return mnHP;
        }
        public bool fGetSkill()
        {
            return mbSkill;
        }
        public bool fGetDead()
        {
            return mbDead;
        }
    }
}
