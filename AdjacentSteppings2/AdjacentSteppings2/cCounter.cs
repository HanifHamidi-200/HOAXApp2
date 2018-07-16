using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentSteppings2
{

    class cCounter
    {
        private static cCell _player1 = new cCell();
        private static cCell _player2 = new cCell();
        private static cCell _player3 = new cCell();
        private static cCell _player4 = new cCell();
        private static cCell _player5 = new cCell();
        private static cCell _player6 = new cCell();
        private static List<int> _status = new List<int> { 1, 1, 1, 1, 1, 1 };
        private static List<bool> _equip1 = new List<bool> {false,false,false,false,false,false };
        private static List<bool> _equip2 = new List<bool> { false, false, false, false, false, false };
        private static List<bool> _equip3 = new List<bool> { false, false, false, false, false, false };
        private static List<bool> _equip4 = new List<bool> { false, false, false, false, false, false };

        private int mnPlayer;

        public void fSetplayer(int nPlayer)
        {
            mnPlayer = nPlayer;
            if (_status[mnPlayer-1] == 3)
            {
                do
                {
                    mnPlayer++;
                    if (mnPlayer == 7)
                    {
                        mnPlayer = 1;
                    }
                } while (_status[mnPlayer-1] == 3);
            }
        }
        public void fSetplayer2(int nPlayer,int nCol,int nRow)
        {
            mnPlayer = nPlayer;
            switch (mnPlayer)
            {
                case 1:
                    _player1.fSetcol(nCol);
                    _player1.fSetrow(nRow);
                    break;
                case 2:
                    _player2.fSetcol(nCol);
                    _player2.fSetrow(nRow);
                    break;
                case 3:
                    _player3.fSetcol(nCol);
                    _player3.fSetrow(nRow);
                    break;
                case 4:
                    _player4.fSetcol(nCol);
                    _player4.fSetrow(nRow);
                    break;
                case 5:
                    _player5.fSetcol(nCol);
                    _player5.fSetrow(nRow);
                    break;
                default:
                    _player6.fSetcol(nCol);
                    _player6.fSetrow(nRow);
                    break;
            }
        }
        public void fSetplayer3(int nPlayer, int nHP, bool bSkill,bool bDead)
        {
            mnPlayer = nPlayer;
            switch (mnPlayer)
            {
                case 1:
                    _player1.fSetHP(nHP);
                    _player1.fSetSkill(bSkill);
                    _player1.fSetDead(bDead);
                    break;
                case 2:
                    _player2.fSetHP(nHP);
                    _player2.fSetSkill(bSkill);
                    _player2.fSetDead(bDead);
                    break;
                case 3:
                    _player3.fSetHP(nHP);
                    _player3.fSetSkill(bSkill);
                    _player3.fSetDead(bDead);
                    break;
                case 4:
                    _player4.fSetHP(nHP);
                    _player4.fSetSkill(bSkill);
                    _player4.fSetDead(bDead);
                    break;
                case 5:
                    _player5.fSetHP(nHP);
                    _player5.fSetSkill(bSkill);
                    _player5.fSetDead(bDead);
                    break;
                default:
                    _player6.fSetHP(nHP);
                    _player6.fSetSkill(bSkill);
                    _player6.fSetDead(bDead);
                    break;
            }
        }
        public void fSetplayer4(int nPlayer, bool bequip1, bool bequip2, bool bequip3,bool bequip4)
        {
            mnPlayer = nPlayer;
            _equip1[mnPlayer - 1] = bequip1;
            _equip2[mnPlayer - 1] = bequip2;
            _equip3[mnPlayer - 1] = bequip3;
            _equip4[mnPlayer - 1] = bequip4;
          
        }

        public int fGetcol()
        {
            switch (mnPlayer)
            {
                case 1:
                    return _player1.fGetcol();
                case 2:
                    return _player2.fGetcol();
                case 3:
                    return _player3.fGetcol();
                case 4:
                    return _player4.fGetcol();
                case 5:
                    return _player5.fGetcol();
                default:
                    return _player6.fGetcol();
            }
        }
        public int fGetrow()
        {
            switch (mnPlayer)
            {
                case 1:
                    return _player1.fGetrow();
                case 2:
                    return _player2.fGetrow();
                case 3:
                    return _player3.fGetrow();
                case 4:
                    return _player4.fGetrow();
                case 5:
                    return _player5.fGetrow();
                default:
                    return _player6.fGetrow();
            }
        }
        public int fGetrotate()
        {
            switch (mnPlayer)
            {
                case 1:
                    return _player1.fGetrotate();
                case 2:
                    return _player2.fGetrotate();
                case 3:
                    return _player3.fGetrotate();
                case 4:
                    return _player4.fGetrotate();
                case 5:
                    return _player5.fGetrotate();
                default:
                    return _player6.fGetrotate();
            }
        }
        public int fGetHP()
        {
            switch (mnPlayer)
            {
                case 1:
                    return _player1.fGetHP();
                case 2:
                    return _player2.fGetHP();
                case 3:
                    return _player3.fGetHP();
                case 4:
                    return _player4.fGetHP();
                case 5:
                    return _player5.fGetHP();
                default:
                    return _player6.fGetHP();
            }
        }
        public bool fGetSkill()
        {
            switch (mnPlayer)
            {
                case 1:
                    return _player1.fGetSkill();
                case 2:
                    return _player2.fGetSkill();
                case 3:
                    return _player3.fGetSkill();
                case 4:
                    return _player4.fGetSkill();
                case 5:
                    return _player5.fGetSkill();
                default:
                    return _player6.fGetSkill();
            }
        }
        public bool fGetDead()
        {
            switch (mnPlayer)
            {
                case 1:
                    return _player1.fGetDead();
                case 2:
                    return _player2.fGetDead();
                case 3:
                    return _player3.fGetDead();
                case 4:
                    return _player4.fGetDead();
                case 5:
                    return _player5.fGetDead();
                default:
                    return _player6.fGetDead();
            }
        }

        public bool fGetequip1()
        {
            return _equip1[mnPlayer - 1];
        }
        public bool fGetequip2()
        {
            return _equip2[mnPlayer - 1];
        }
        public bool fGetequip3()
        {
            return _equip3[mnPlayer - 1];
        }
        public bool fGetequip4()
        {
            return _equip4[mnPlayer - 1];
        }

        public int fGetstatus()
        {
            return _status[mnPlayer - 1];
        }
        public void fSetstatus(int nValue)
        {
            _status[mnPlayer - 1] = nValue;
            /*1=Fighting
             *2=Guarding/Waiting
             *3=Dead
            */
        }
    }
}
