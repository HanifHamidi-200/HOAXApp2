using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{
    class cEnemies
    {
        private static cCell _enemies1 = new cCell();
        private static cCell _enemies2 = new cCell();
        private static cCell _enemies3 = new cCell();
        private static cCell _enemies4 = new cCell();
        private static cCell _enemies5 = new cCell();
        private static cCell _enemies6 = new cCell();
        private static cCell _enemies7 = new cCell();
        private static cCell _enemies8 = new cCell();
        private static cCell _enemies9 = new cCell();
        private static cCell _enemies10 = new cCell();
        private static cCell _enemies11 = new cCell();
        private static cCell _enemies12 = new cCell();
        private static cCell _enemies13 = new cCell();
        private static cCell _enemies14= new cCell();
        private static cCell _enemies15 = new cCell();
        private static cCell _enemies16 = new cCell();
        private static cCell _enemies17= new cCell();
        private static cCell _enemies18= new cCell();
        private static cCell _enemies19 = new cCell();
        private static cCell _enemies20 = new cCell();
        private int mnEnemy;
        private static List<int> _status = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ,1,1};

        public bool fGetEnemyDead(int nEnemy)
        {
            return (_status[nEnemy - 1] == 3);
        }
        public void fSetenemy(int nEnemy)
        {
            mnEnemy = nEnemy;
            if (_status[mnEnemy-1] == 3)
            {
                do
                {
                    mnEnemy++;
                    if (mnEnemy == 21)
                    {
                        mnEnemy = 1;
                    }
                } while (_status[mnEnemy-1] == 3);
            }
        }
        public void fSetenemies2(int nEnemies, int nCol,int nRow)
        {
            mnEnemy = nEnemies;
            switch (mnEnemy)
            {
                case 1:
                    _enemies1.fSetcol(nCol);
                    _enemies1.fSetrow(nRow);
                    break;
                case 2:
                    _enemies2.fSetcol(nCol);
                    _enemies2.fSetrow(nRow);
                    break;
                case 3:
                    _enemies3.fSetcol(nCol);
                    _enemies3.fSetrow(nRow);
                    break;
                case 4:
                    _enemies4.fSetcol(nCol);
                    _enemies4.fSetrow(nRow);
                    break;
                case 5:
                    _enemies5.fSetcol(nCol);
                    _enemies5.fSetrow(nRow);
                    break;
                case 6:
                    _enemies6.fSetcol(nCol);
                    _enemies6.fSetrow(nRow);
                    break;
                case 7:
                    _enemies7.fSetcol(nCol);
                    _enemies7.fSetrow(nRow);
                    break;
                case 8:
                    _enemies8.fSetcol(nCol);
                    _enemies8.fSetrow(nRow);
                    break;
                case 9:
                    _enemies9.fSetcol(nCol);
                    _enemies9.fSetrow(nRow);
                    break;
                case 10:
                    _enemies10.fSetcol(nCol);
                    _enemies10.fSetrow(nRow);
                    break;
                case 11:
                    _enemies11.fSetcol(nCol);
                    _enemies11.fSetrow(nRow);
                    break;
                case 12:
                    _enemies12.fSetcol(nCol);
                    _enemies12.fSetrow(nRow);
                    break;
                case 13:
                    _enemies13.fSetcol(nCol);
                    _enemies13.fSetrow(nRow);
                    break;
                case 14:
                    _enemies14.fSetcol(nCol);
                    _enemies14.fSetrow(nRow);
                    break;
                case 15:
                    _enemies15.fSetcol(nCol);
                    _enemies15.fSetrow(nRow);
                    break;
                case 16:
                    _enemies16.fSetcol(nCol);
                    _enemies16.fSetrow(nRow);
                    break;
                case 17:
                    _enemies17.fSetcol(nCol);
                    _enemies17.fSetrow(nRow);
                    break;
                case 18:
                    _enemies18.fSetcol(nCol);
                    _enemies18.fSetrow(nRow);
                    break;
                case 19:
                    _enemies19.fSetcol(nCol);
                    _enemies19.fSetrow(nRow);
                    break;
                default:
                    _enemies20.fSetcol(nCol);
                    _enemies20.fSetrow(nRow);
                    break;
            }
        }

        public void fSetenemies3(int nEnemies,int nHP, bool bSkill, bool bDead)
        {
            mnEnemy = nEnemies;
            switch (mnEnemy)
            {
                case 1:
                    _enemies1.fSetHP(nHP);
                    _enemies1.fSetSkill(bSkill);
                    _enemies1.fSetDead(bDead);
                    break;
                case 2:
                    _enemies2.fSetHP(nHP);
                    _enemies2.fSetSkill(bSkill);
                    _enemies2.fSetDead(bDead);
                    break;
                case 3:
                    _enemies3.fSetHP(nHP);
                    _enemies3.fSetSkill(bSkill);
                    _enemies3.fSetDead(bDead);
                    break;
                case 4:
                    _enemies4.fSetHP(nHP);
                    _enemies4.fSetSkill(bSkill);
                    _enemies4.fSetDead(bDead);
                    break;
                case 5:
                    _enemies5.fSetHP(nHP);
                    _enemies5.fSetSkill(bSkill);
                    _enemies5.fSetDead(bDead);
                    break;
                case 6:
                    _enemies6.fSetHP(nHP);
                    _enemies6.fSetSkill(bSkill);
                    _enemies6.fSetDead(bDead);
                    break;
                case 7:
                    _enemies7.fSetHP(nHP);
                    _enemies7.fSetSkill(bSkill);
                    _enemies7.fSetDead(bDead);
                    break;
                case 8:
                    _enemies8.fSetHP(nHP);
                    _enemies8.fSetSkill(bSkill);
                    _enemies8.fSetDead(bDead);
                    break;
                case 9:
                    _enemies9.fSetHP(nHP);
                    _enemies9.fSetSkill(bSkill);
                    _enemies9.fSetDead(bDead);
                    break;
                case 10:
                    _enemies10.fSetHP(nHP);
                    _enemies10.fSetSkill(bSkill);
                    _enemies10.fSetDead(bDead);
                    break;
                case 11:
                    _enemies11.fSetHP(nHP);
                    _enemies11.fSetSkill(bSkill);
                    _enemies11.fSetDead(bDead);
                    break;
                case 12:
                    _enemies12.fSetHP(nHP);
                    _enemies12.fSetSkill(bSkill);
                    _enemies12.fSetDead(bDead);
                    break;
                case 13:
                    _enemies13.fSetHP(nHP);
                    _enemies13.fSetSkill(bSkill);
                    _enemies13.fSetDead(bDead);
                    break;
                case 14:
                    _enemies14.fSetHP(nHP);
                    _enemies14.fSetSkill(bSkill);
                    _enemies14.fSetDead(bDead);
                    break;
                case 15:
                    _enemies15.fSetHP(nHP);
                    _enemies15.fSetSkill(bSkill);
                    _enemies15.fSetDead(bDead);
                    break;
                case 16:
                    _enemies16.fSetHP(nHP);
                    _enemies16.fSetSkill(bSkill);
                    _enemies16.fSetDead(bDead);
                    break;
                case 17:
                    _enemies17.fSetHP(nHP);
                    _enemies17.fSetSkill(bSkill);
                    _enemies17.fSetDead(bDead);
                    break;
                case 18:
                    _enemies18.fSetHP(nHP);
                    _enemies18.fSetSkill(bSkill);
                    _enemies18.fSetDead(bDead);
                    break;
                case 19:
                    _enemies19.fSetHP(nHP);
                    _enemies19.fSetSkill(bSkill);
                    _enemies19.fSetDead(bDead);
                    break;
                default:
                    _enemies20.fSetHP(nHP);
                    _enemies20.fSetSkill(bSkill);
                    _enemies20.fSetDead(bDead);
                    break;
            }
        }

        public int fGetcol()
        {
            switch (mnEnemy)
            {
                case 1:
                    return _enemies1.fGetcol();
                case 2:
                    return _enemies2.fGetcol();
                case 3:
                    return _enemies3.fGetcol();
                case 4:
                    return _enemies4.fGetcol();
                case 5:
                    return _enemies5.fGetcol();
                case 6:
                    return _enemies6.fGetcol();
                case 7:
                    return _enemies7.fGetcol();
                case 8:
                    return _enemies8.fGetcol();
                case 9:
                    return _enemies9.fGetcol();
                case 10:
                    return _enemies10.fGetcol();
                case 11:
                    return _enemies11.fGetcol();
                case 12:
                    return _enemies12.fGetcol();
                case 13:
                    return _enemies13.fGetcol();
                case 14:
                    return _enemies14.fGetcol();
                case 15:
                    return _enemies15.fGetcol();
                case 16:
                    return _enemies16.fGetcol();
                case 17:
                    return _enemies17.fGetcol();
                case 18:
                    return _enemies18.fGetcol();
                case 19:
                    return _enemies19.fGetcol();
                default:
                    return _enemies20.fGetcol();
            }
        }

        public int fGetrow()
        {
            switch (mnEnemy)
            {
                case 1:
                    return _enemies1.fGetrow();
                case 2:
                    return _enemies2.fGetrow();
                case 3:
                    return _enemies3.fGetrow();
                case 4:
                    return _enemies4.fGetrow();
                case 5:
                    return _enemies5.fGetrow();
                case 6:
                    return _enemies6.fGetrow();
                case 7:
                    return _enemies7.fGetrow();
                case 8:
                    return _enemies8.fGetrow();
                case 9:
                    return _enemies9.fGetrow();
                case 10:
                    return _enemies10.fGetrow();
                case 11:
                    return _enemies11.fGetrow();
                case 12:
                    return _enemies12.fGetrow();
                case 13:
                    return _enemies13.fGetrow();
                case 14:
                    return _enemies14.fGetrow();
                case 15:
                    return _enemies15.fGetrow();
                case 16:
                    return _enemies16.fGetrow();
                case 17:
                    return _enemies17.fGetrow();
                case 18:
                    return _enemies18.fGetrow();
                case 19:
                    return _enemies19.fGetrow();
                   default:
                    return _enemies20.fGetrow();
            }
        }

        public int fGetrotate()
        {
            switch (mnEnemy)
            {
                case 1:
                    return _enemies1.fGetrotate();
                case 2:
                    return _enemies2.fGetrotate();
                case 3:
                    return _enemies3.fGetrotate();
                case 4:
                    return _enemies4.fGetrotate();
                case 5:
                    return _enemies5.fGetrotate();
                case 6:
                    return _enemies6.fGetrotate();
                case 7:
                    return _enemies7.fGetrotate();
                case 8:
                    return _enemies8.fGetrotate();
                case 9:
                    return _enemies9.fGetrotate();
                case 10:
                    return _enemies10.fGetrotate();
                case 11:
                    return _enemies11.fGetrotate();
                case 12:
                    return _enemies12.fGetrotate();
                case 13:
                    return _enemies13.fGetrotate();
                case 14:
                    return _enemies14.fGetrotate();
                case 15:
                    return _enemies15.fGetrotate();
                case 16:
                    return _enemies16.fGetrotate();
                case 17:
                    return _enemies17.fGetrotate();
                case 18:
                    return _enemies18.fGetrotate();
                case 19:
                    return _enemies19.fGetrotate();
                default:
                    return _enemies20.fGetrotate();
            }
        }

        public int fGetHP()
        {
            switch (mnEnemy)
            {
                case 1:
                    return _enemies1.fGetHP();
                case 2:
                    return _enemies2.fGetHP();
                case 3:
                    return _enemies3.fGetHP();
                case 4:
                    return _enemies4.fGetHP();
                case 5:
                    return _enemies5.fGetHP();
                case 6:
                    return _enemies6.fGetHP();
                case 7:
                    return _enemies7.fGetHP();
                case 8:
                    return _enemies8.fGetHP();
                case 9:
                    return _enemies9.fGetHP();
                case 10:
                    return _enemies10.fGetHP();
                case 11:
                    return _enemies11.fGetHP();
                case 12:
                    return _enemies12.fGetHP();
                case 13:
                    return _enemies13.fGetHP();
                case 14:
                    return _enemies14.fGetHP();
                case 15:
                    return _enemies15.fGetHP();
                case 16:
                    return _enemies16.fGetHP();
                case 17:
                    return _enemies17.fGetHP();
                case 18:
                    return _enemies18.fGetHP();
                case 19:
                    return _enemies19.fGetHP();
                default:
                    return _enemies20.fGetHP();
            }
        }

        public bool fGetSkill()
        {
            switch (mnEnemy)
            {
                case 1:
                    return _enemies1.fGetSkill();
                case 2:
                    return _enemies2.fGetSkill();
                case 3:
                    return _enemies3.fGetSkill();
                case 4:
                    return _enemies4.fGetSkill();
                case 5:
                    return _enemies5.fGetSkill();
                case 6:
                    return _enemies6.fGetSkill();
                case 7:
                    return _enemies7.fGetSkill();
                case 8:
                    return _enemies8.fGetSkill();
                case 9:
                    return _enemies9.fGetSkill();
                case 10:
                    return _enemies10.fGetSkill();
                case 11:
                    return _enemies11.fGetSkill();
                case 12:
                    return _enemies12.fGetSkill();
                case 13:
                    return _enemies13.fGetSkill();
                case 14:
                    return _enemies14.fGetSkill();
                case 15:
                    return _enemies15.fGetSkill();
                case 16:
                    return _enemies16.fGetSkill();
                case 17:
                    return _enemies17.fGetSkill();
                case 18:
                    return _enemies18.fGetSkill();
                case 19:
                    return _enemies19.fGetSkill();
                default:
                    return _enemies20.fGetSkill();
            }
        }

        public bool fGetDead()
        {
            switch (mnEnemy)
            {
                case 1:
                    return _enemies1.fGetDead();
                case 2:
                    return _enemies2.fGetDead();
                case 3:
                    return _enemies3.fGetDead();
                case 4:
                    return _enemies4.fGetDead();
                case 5:
                    return _enemies5.fGetDead();
                case 6:
                    return _enemies6.fGetDead();
                case 7:
                    return _enemies7.fGetDead();
                case 8:
                    return _enemies8.fGetDead();
                case 9:
                    return _enemies9.fGetDead();
                case 10:
                    return _enemies10.fGetDead();
                case 11:
                    return _enemies11.fGetDead();
                case 12:
                    return _enemies12.fGetDead();
                case 13:
                    return _enemies13.fGetDead();
                case 14:
                    return _enemies14.fGetDead();
                case 15:
                    return _enemies15.fGetDead();
                case 16:
                    return _enemies16.fGetDead();
                case 17:
                    return _enemies17.fGetDead();
                case 18:
                    return _enemies18.fGetDead();
                case 19:
                    return _enemies19.fGetDead();
                default:
                    return _enemies20.fGetDead();
            }
        }
        public int fGetstatus()
        {
            return _status[mnEnemy - 1];
        }
        public void fSetstatus(int nValue)
        {
            _status[mnEnemy - 1] = nValue;
            /*1=Fighting
             *2=Guarding/Waiting
             *3=Dead
            */
        }
    }
}
