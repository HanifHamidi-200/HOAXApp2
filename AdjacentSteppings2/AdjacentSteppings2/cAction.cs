using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cAction
    {
        private int mnAction;

        public void fSetaction(int nValue)
        {
            mnAction = nValue;
        }

        public bool fValidSpace(bool bEquipsword,bool bEquipshield,bool bEquipbow,bool bCharclassmage)
        {
            switch (mnAction)
            {
                case 1:
                    if (bEquipsword)
                    {
                        if (bEquipshield)
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
                case 2:
                    if (bEquipbow)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (bCharclassmage)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    if (bCharclassmage)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

            }
        }

        public void fSword(bool bSkill,ref int nHP,ref bool bDead)
        {
            Random rnd1 = new Random();
            int nTake = rnd1.Next(6, 27);

            if (bSkill)
            {
                nTake = nTake * 2;
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
        public void fBow(bool bSkill, ref int nHP, ref bool bDead)
        {
            Random rnd1 = new Random();
            int nTake = rnd1.Next(6, 17);

            if (bSkill)
            {
                nTake = nTake * 2;
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
        public void fFireball(bool bSkill, ref int nHP, ref bool bDead,ref bool bResist)
        {
            Random rnd1 = new Random();
            int nTake = rnd1.Next(13, 37);
            int nResist = rnd1.Next(1, 10);

            if (nResist <= 1)
            {
                bResist = true;
            }
            else
            {
                bResist = false;
            }

            if (bSkill)
            {
                nTake = nTake * 2;
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
        public void fHoldperson( ref bool bResist)
        {
            Random rnd1 = new Random();
            int nResist = rnd1.Next(1, 10);

            if (nResist <= 2)
            {
                bResist = true;
            }
            else
            {
                bResist = false;
            }

         }

        public bool fValidTarget(int nRangegiven)
        {
            switch (mnAction)
            {
                case 1:
                    if (nRangegiven == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (nRangegiven <=6)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (nRangegiven <=10)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    if (nRangegiven <=6)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
        }
    }
}
