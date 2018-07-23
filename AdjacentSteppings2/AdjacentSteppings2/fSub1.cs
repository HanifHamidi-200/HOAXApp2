using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdjacentSteppings2
{
    public partial class fSub1 : Form
    {
        private cBoard _board = new cBoard();
        private cDisplay _display = new cDisplay();
        private cCounter _counter = new cCounter();
        private cEnemies _enemies = new cEnemies();
        private cAction _action = new cAction();
        private cActionKnock _actionknock = new cActionKnock();
        private cFlee _actionflee = new cFlee();
        private cSearch _actionsearch = new cSearch();
        private cSkill _skill = new cSkill();
        private cPsychOut _psychout = new cPsychOut();
        private cEnemiesChoke _enemieschoke = new cEnemiesChoke();
        private cTrap _enemiestrap = new cTrap();
        private int mnCol, mnRow;
        private int mnCol2, mnRow2;
        private int mnMovesleft;
        private int mnPlayers, mnEnemies;
        private int nNumber;
        private int mnModeSquareRow;
        private int mnBLANK = 1, mnBUSH = 3, mnENEMY = 4, mnEXIT = 6, mnFIREBALL = 7, mnFRUITS = 8, mnHOLDPERSON = 10, mnDYING = 11, mnROAD = 12, mnSTONES = 13, mnCHARACTER = 15, mnNULLGATE = 17;
        private int mnPlayer = 1, mnAction = 1;
        private int mnDeadcol, mnDeadrow;
        private int mnFireballcol, mnFireballrow;
        private int nScore;

        private void fFireball(int nCol, int nRow)
        {
            mnFireballcol = nCol;
            mnFireballrow = nRow;
            for (int i = mnFireballcol - 2; i <= mnFireballcol + 2; i++)
            {
                if (i >= 1)
                {
                    if (i <= 8)
                    {
                        for (int j = mnFireballcol - 2; j <= mnFireballcol + 2; j++)
                        {
                            if (j >= 1)
                            {
                                if (j <= 30)
                                {
                                    _board.fSetcol(i);
                                    _board.fSetrow(j);
                                         _board.fSetwait(mnFIREBALL);
                                        _board.fWrite();
                               
                                }
                            }
                        }

                    }
                }
            }

            fUpdateDisplay();
            tmrFireball.Enabled = true;
        }
            
            private void fKill(int nEnemy)
        {
            int nCol, nRow;

            _enemies.fSetenemy(nEnemy);
            _enemies.fSetstatus(3);
            nCol = _enemies.fGetcol();
            nRow = _enemies.fGetrow();
            _board.fSetcol(nCol);
            _board.fSetrow(nRow);
            _board.fSetwait(mnDYING);
            _board.fWrite();
            mnDeadcol = nCol;
            mnDeadrow = nRow;
            fUpdateDisplay();
            tmrDead.Enabled = true;
        }
        private void fHoldperson(int nEnemy)
        {
            int nCol, nRow;

            _enemies.fSetenemy(nEnemy);
            nCol = _enemies.fGetcol();
            nRow = _enemies.fGetrow();
            _board.fSetcol(nCol);
            _board.fSetrow(nRow);
            _board.fSetwait(mnHOLDPERSON);
            _board.fWrite();
            mnDeadcol = nCol;
            mnDeadrow = nRow;
            fUpdateDisplay();
            tmrDead.Enabled = true;
        }

        private void fList1(int nPlayer, int nHP, bool bSkill, bool bDead, bool bEquip1, bool bEquip2, bool bEquip3, bool bEquip4)
        {
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);

            }

            sText = "Player" + Convert.ToString(nPlayer);
            lst1.Items.Add(sText);
            sText = "HP = " + Convert.ToString(nHP);
            lst1.Items.Add(sText);
            if (bSkill)
            {
                sText = "Skill = true";
            }
            else
            {
                sText = "Skill = false";
            }
            lst1.Items.Add(sText);
            if (bDead)
            {
                sText = "Dead = true";
            }
            else
            {
                sText = "Dead = false";
            }
            lst1.Items.Add(sText);
        }
        private int fEnemyNumber(int nCol, int nRow)
        {
            int nCol2, nRow2;
            bool bDead;

            for (int i = 1; i <= 20; i++)
            {
                _enemies.fSetenemy(i);
                nCol2 = _enemies.fGetcol();
                nRow2 = _enemies.fGetrow();
                if (nCol == nCol2)
                {
                    if (nRow == nRow2)
                    {
                        bDead = _enemies.fGetDead();
                        if (bDead)
                        {
                            return 0;
                        }
                        else
                        {
                            return i;
                        }
                    }
                }
            }

            return 0;
        }
        private bool fCellNext(int nCol1, int nRow1, int nCol2, int nRow2)
        {
            int nDirection;
            bool bFound = false;
            int nCol3 = nCol1;
            int nRow3 = nRow1;

            for (int i = 1; i <= 8; i++)
            {
                nDirection = i;
                nCol1 = nCol3;
                nRow1 = nRow3;
                switch (nDirection)
                {
                    case 1:
                        nRow1 += 1;
                        if (nRow1 <= 30)
                        {

                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 2:
                        nRow1 += 1;
                        nCol1 += 1;
                        if (nRow1 <= 30)
                        {
                            if (nCol1 <= 8)
                            {

                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 3:
                        nCol1 += 1;
                        if (nCol1 <= 8)
                        {

                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 4:
                        nRow1 -= 1;
                        nCol1 += 1;
                        if (nRow1 >= 1)
                        {
                            if (nCol1 <= 8)
                            {

                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 5:
                        nRow1 -= 1;
                        if (nRow1 >= 1)
                        {

                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 6:
                        nRow1 -= 1;
                        nCol1 -= 1;
                        if (nRow1 >= 1)
                        {
                            if (nCol1 >= 1)
                            {

                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case 7:
                        nCol1 -= 1;
                        if (nCol1 >= 1)
                        {

                        }
                        else
                        {
                            continue;
                        }
                        break;
                    default:
                        nRow1 += 1;
                        nCol1 -= 1;
                        if (nRow1 <= 30)
                        {
                            if (nCol1 >= 1)
                            {

                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;

                }
                if (nCol1 == nCol2)
                {
                    if (nRow1 == nRow2)
                    {
                        bFound = true;
                        continue;
                    }
                }
            }
            return bFound;
        }

            private void fActionClick(int nCol, int nRow)
        {
            int nCol2, nRow2;
            bool bequip1, bequip2, bequip3, bequip4;
            bool bValid;
            String sText = null;
            int nHP;
            bool bSkill, bDead, bResist = false;
            int nEnemyNumber;

            if (mnMovesleft == 0)
            {
                fPNext();
                return;
            }
            _counter.fSetplayer(mnPlayer);
            nCol2 = _counter.fGetcol();
            nRow2 = _counter.fGetrow();
            bequip1 = _counter.fGetequip1();
            bequip2 = _counter.fGetequip2();
            bequip3 = _counter.fGetequip3();
            bequip4 = _counter.fGetequip4();

            nRow = (mnModeSquareRow - 7) + (9 - nRow) - 1;
            nEnemyNumber = fEnemyNumber(nCol, nRow);

            switch (mnAction)
            {
                case 1:
                    if (fCellNext(nCol, nRow, nCol2, nRow2))
                    {
                        _action.fSetaction(mnAction);
                        bValid = _action.fValidSpace(bequip1, bequip2, bequip3, bequip4);
                        if (bValid == false)
                        {
                            MessageBox.Show("Error!");
                            sText = "[" + Convert.ToString(mnMovesleft) + "] = error!";
                            lst2.Items.Add(sText);
                            mnMovesleft -= 1;
                            return;
                        }
                        if (nEnemyNumber == 0)
                        {
                            MessageBox.Show("Error!");
                            sText = "[" + Convert.ToString(mnMovesleft) + "] = error!";
                            lst2.Items.Add(sText);
                            mnMovesleft -= 1;
                            return;
                        }
                        _enemies.fSetenemy(nEnemyNumber);
                        nHP = _enemies.fGetHP();
                        bSkill = _enemies.fGetSkill();
                        bDead = _enemies.fGetDead();
                        _action.fSword(bSkill, ref nHP, ref bDead);
                        _enemies.fSetenemies3(nEnemyNumber, nHP, bSkill, bDead);
                        if (bDead)
                        {
                            sText = "[" + Convert.ToString(mnMovesleft) + "] = ENEMY DEAD";
                            fKill(nEnemyNumber);
                        }
                        else
                        {
                            sText = "[" + Convert.ToString(mnMovesleft) + "] = Enemy down to " + Convert.ToString(nHP) + "HP";
                        }
                        lst2.Items.Add(sText);
                        mnMovesleft -= 1;
                    }
                    break;
                case 2:
                    _action.fSetaction(mnAction);
                    bValid = _action.fValidSpace(bequip1, bequip2, bequip3, bequip4);
                    if (bValid == false)
                    {
                        MessageBox.Show("Error!");
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = error!";
                        lst2.Items.Add(sText);
                        mnMovesleft -= 1;
                        return;
                    }
                    if (nEnemyNumber == 0)
                    {
                        MessageBox.Show("Error!");
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = error!";
                        lst2.Items.Add(sText);
                        mnMovesleft -= 1;
                        return;
                    }
                    _enemies.fSetenemy(nEnemyNumber);
                    nHP = _enemies.fGetHP();
                    bSkill = _enemies.fGetSkill();
                    bDead = _enemies.fGetDead();
                    _action.fBow(bSkill, ref nHP, ref bDead);
                    _enemies.fSetenemies3(nEnemyNumber, nHP, bSkill, bDead);
                    if (bDead)
                    {
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = ENEMY DEAD";
                        fKill(nEnemyNumber);
                    }
                    else
                    {
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = Enemy down to " + Convert.ToString(nHP) + "HP";
                    }
                    lst2.Items.Add(sText);
                    mnMovesleft -= 1;
                    break;
                case 3:
                    _action.fSetaction(mnAction);
                    bValid = _action.fValidSpace(bequip1, bequip2, bequip3, bequip4);
                    if (bValid == false)
                    {
                        MessageBox.Show("Error!");
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = error!";
                        lst2.Items.Add(sText);
                        mnMovesleft -= 1;
                        return;
                    }
                    if (nEnemyNumber > 0)
                    {
                        nHP = _enemies.fGetHP();
                        bSkill = _enemies.fGetSkill();
                        bDead = _enemies.fGetDead();
                        _action.fFireball(bSkill, ref nHP, ref bDead, ref bResist);
                        _enemies.fSetenemies3(nEnemyNumber, nHP, bSkill, bDead);
                        if (bDead)
                        {
                            sText = "[" + Convert.ToString(mnMovesleft) + "] = ENEMY DEAD";
                            fFireball(nCol,nRow);
                        }
                        else
                        {
                            if (bResist)
                            {
                                sText = "[" + Convert.ToString(mnMovesleft) + "] = resist!";
                            }
                            else
                            {
                                sText = "[" + Convert.ToString(mnMovesleft) + "] = Enemy down to " + Convert.ToString(nHP) + "HP";
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error!");
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = error!";
                        lst2.Items.Add(sText);
                        mnMovesleft -= 1;
                        return;
                    }
                    lst2.Items.Add(sText);
                     mnMovesleft -= 1;
                    break;
                default:
                    _action.fSetaction(mnAction);
                    bValid = _action.fValidSpace(bequip1, bequip2, bequip3, bequip4);
                    if (bValid == false)
                    {
                        MessageBox.Show("Error!");
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = error!";
                        lst2.Items.Add(sText);
                        mnMovesleft -= 1;
                        return;
                    }
                    if (nEnemyNumber == 0)
                    {
                        MessageBox.Show("Error!");
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = error!";
                        lst2.Items.Add(sText);
                        mnMovesleft -= 1;
                        return;
                    }
                    _enemies.fSetenemy(nEnemyNumber);
                    _action.fHoldperson(ref bResist);
                    if (bResist)
                    {
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = resist!";
                    }
                    else
                    {
                        sText = "[" + Convert.ToString(mnMovesleft) + "] = Enemy held";
                        fHoldperson(nEnemyNumber);
                    }
                    lst2.Items.Add(sText);
                    mnMovesleft -= 1;
                    break;
            }
        }

        private void fUpgradeback()
        {
            int nCol, nRow;

            _counter.fSetplayer(mnPlayer);
            nCol = _counter.fGetcol();
            nRow = _counter.fGetrow();

            mnCol = nCol;
            mnRow = nRow;

            if (mnRow >= mnModeSquareRow)
            {
                if (mnRow > mnModeSquareRow + 7)
                {
                    mnModeSquareRow = mnRow;
                }
            }
            else
            {
                mnModeSquareRow = mnRow;
            }
            lblRow1a.Text = Convert.ToString(mnModeSquareRow);
            lblRow1b.Text = Convert.ToString(mnModeSquareRow);
            lblRow8a.Text = Convert.ToString(mnModeSquareRow - 7);
            lblRow8b.Text = Convert.ToString(mnModeSquareRow - 7);

            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            lblRow.Text = "Row " + Convert.ToString(mnModeSquareRow) + "/30";

            fCopy();
            fUpdateDisplay();

        }
        private void fUpgradeback2()
        {
            int nCol, nRow;

            _enemies.fSetenemy(mnEnemies);
            nCol = _enemies.fGetcol();
            nRow = _enemies.fGetrow();

            mnCol = nCol;
            mnRow = nRow;

            if (mnRow >= mnModeSquareRow)
            {
                if (mnRow > mnModeSquareRow + 7)
                {
                    mnModeSquareRow = mnRow;
                }
            }
            else
            {
                mnModeSquareRow = mnRow;
            }
            lblRow1a.Text = Convert.ToString(mnModeSquareRow);
            lblRow1b.Text = Convert.ToString(mnModeSquareRow);
            lblRow8a.Text = Convert.ToString(mnModeSquareRow - 7);
            lblRow8b.Text = Convert.ToString(mnModeSquareRow - 7);

            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            lblRow.Text = "Row " + Convert.ToString(mnModeSquareRow) + "/30";

            fCopy();
            fUpdateDisplay();

        }
        private void fUpgrade(int nMode)
        {
            if (nMode == 1)
            {
                mnModeSquareRow += 9;
                if (mnModeSquareRow > 30)
                {
                    mnModeSquareRow = 30;
                }
            }
            else
            {
                mnModeSquareRow -= 9;
                if (mnModeSquareRow - 7 < 1)
                {
                    mnModeSquareRow = 8;
                }
            }
            lblRow1a.Text = Convert.ToString(mnModeSquareRow);
            lblRow1b.Text = Convert.ToString(mnModeSquareRow);
            lblRow8a.Text = Convert.ToString(mnModeSquareRow - 7);
            lblRow8b.Text = Convert.ToString(mnModeSquareRow - 7);
            fCopy();
            fUpdateDisplay();
        }

        private void fNav(int nMode)
        {
            int nCol, nRow, nRotate;
            String sText;

            _counter.fSetplayer(mnPlayer);
            nCol = _counter.fGetcol();
            nRow = _counter.fGetrow();
            nRotate = _counter.fGetrotate();

            switch (nMode)
            {
                case 1:
                    mnCol = nCol;
                    mnRow = nRow + 1;
                    sText = "[" + Convert.ToString(mnMovesleft) + "] = up";
                    break;
                case 2:
                    mnCol = nCol + 1;
                    mnRow = nRow;
                    sText = "[" + Convert.ToString(mnMovesleft) + "] = right";
                    break;
                case 3:
                    mnCol = nCol;
                    mnRow = nRow - 1;
                    sText = "[" + Convert.ToString(mnMovesleft) + "] = down";
                    break;
                default:
                    mnCol = nCol - 1;
                    mnRow = nRow;
                    sText = "[" + Convert.ToString(mnMovesleft) + "] = left";
                    break;
            }
            nRotate = nMode;
            if (mnCol == 0)
            {
                return;
            }
            if (mnCol == 31)
            {
                return;
            }
            if (mnRow == 0)
            {
                return;
            }
            if (mnCol == 9)
            {
                return;
            }
            lst2.Items.Add(sText);
            mnMovesleft -= 1;
            _counter.fSetplayer2(mnPlayer, mnCol, mnRow);
            _board.fSetcol(nCol);
            _board.fSetrow(nRow);
            _board.fSetRotate(1);
            _board.fSetwait(mnBLANK);
            _board.fWrite();
            _board.fSetcol(mnCol);
            _board.fSetrow(mnRow);
            _board.fSetRotate(nRotate);
            _board.fSetwait(mnCHARACTER);
            _board.fWrite();
            if (mnRow >= mnModeSquareRow)
            {
                if (mnRow > mnModeSquareRow + 7)
                {
                    mnModeSquareRow = mnRow;
                }
            }
            else
            {
                mnModeSquareRow = mnRow;
            }
            lblRow1a.Text = Convert.ToString(mnModeSquareRow);
            lblRow1b.Text = Convert.ToString(mnModeSquareRow);
            lblRow8a.Text = Convert.ToString(mnModeSquareRow - 7);
            lblRow8b.Text = Convert.ToString(mnModeSquareRow - 7);
            /*
                 _display.fSetcol(mnCol);
                 _display.fSetrow(mnModeSquareRow);
                 _display.fSetRotate(nRotate);
                 _display.fSetwait(mnCHARACTER);
                 _display.fWrite();
                 */
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            lblRow.Text = "Row " + Convert.ToString(mnModeSquareRow) + "/30";


        }
        private void fUpgradeyou()
        {
            fUpgradeback();
        }

        private void fStick(int nCol, int nRow, int nType, int nRotate)
        {
            _board.fSetcol(nCol);
            _board.fSetrow(nRow);
            _board.fSetRotate(nRotate);
            _board.fSetwait(nType);
            _board.fWrite();
        }
        private void fStick2(int nCol, int nRow, int nType, int nRotate)
        {
            _display.fSetcol(nCol);
            _display.fSetrow(nRow);
            _display.fSetRotate(nRotate);
            _display.fSetwait(nType);
            _display.fWrite();
        }

        private void btnAction2_Click(object sender, EventArgs e)
        {
            mnAction = 2;
        }

        private void btnAction3_Click(object sender, EventArgs e)
        {
            mnAction = 3;
        }

        private void btnAction4_Click(object sender, EventArgs e)
        {
            mnAction = 4;
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            fPNext();
        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            fNav(1);
        }

        private void btnUpdateDisplay_Click(object sender, EventArgs e)
        {
            fCopy();
            fUpdateDisplay();

        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            fNav(2);
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            fNav(3);
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            fNav(4);
        }

        private void btnUpgrade2_Click(object sender, EventArgs e)
        {
            fUpgrade(2);
        }

        private void btnUpgrade3_Click(object sender, EventArgs e)
        {
            mnEnemies++;
            if (mnEnemies > 20)
            {
                mnEnemies = 1;
            }
            fUpgradeback2();
        }

        private void btnUpgrade4_Click(object sender, EventArgs e)
        {
            fUpgradeback();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            fActionClick(1, 1);
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            fActionClick(1, 2);
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            fActionClick(1, 3);
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            fActionClick(1, 4);
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            fActionClick(1, 5);
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            fActionClick(1, 6);
        }

        private void pic17_Click(object sender, EventArgs e)
        {
            fActionClick(1, 7);
        }

        private void pic18_Click(object sender, EventArgs e)
        {
            fActionClick(1, 8);
        }

        private void pic21_Click(object sender, EventArgs e)
        {
            fActionClick(2, 1);
        }

        private void pic22_Click(object sender, EventArgs e)
        {
            fActionClick(2, 2);
        }

        private void pic23_Click(object sender, EventArgs e)
        {
            fActionClick(2, 3);
        }

        private void pic24_Click(object sender, EventArgs e)
        {
            fActionClick(2, 4);
        }

        private void pic25_Click(object sender, EventArgs e)
        {
            fActionClick(2, 5);
        }

        private void pic26_Click(object sender, EventArgs e)
        {
            fActionClick(2, 6);
        }

        private void pic27_Click(object sender, EventArgs e)
        {
            fActionClick(2, 7);
        }

        private void pic28_Click(object sender, EventArgs e)
        {
            fActionClick(2, 8);
        }

        private void pic31_Click(object sender, EventArgs e)
        {
            fActionClick(3, 1);
        }

        private void pic32_Click(object sender, EventArgs e)
        {
            fActionClick(3, 2);
        }

        private void pic33_Click(object sender, EventArgs e)
        {
            fActionClick(3, 3);
        }

        private void pic34_Click(object sender, EventArgs e)
        {
            fActionClick(3, 4);
        }

        private void pic35_Click(object sender, EventArgs e)
        {
            fActionClick(3, 5);
        }

        private void pic36_Click(object sender, EventArgs e)
        {
            fActionClick(3, 6);
        }

        private void pic37_Click(object sender, EventArgs e)
        {
            fActionClick(3, 7);
        }

        private void pic38_Click(object sender, EventArgs e)
        {
            fActionClick(3, 8);
        }

        private void pic41_Click(object sender, EventArgs e)
        {
            fActionClick(4, 1);
        }

        private void pic42_Click(object sender, EventArgs e)
        {
            fActionClick(4, 2);
        }

        private void pic43_Click(object sender, EventArgs e)
        {
            fActionClick(4, 3);
        }

        private void pic44_Click(object sender, EventArgs e)
        {
            fActionClick(4, 4);
        }

        private void pic45_Click(object sender, EventArgs e)
        {
            fActionClick(4, 5);
        }

        private void pic46_Click(object sender, EventArgs e)
        {
            fActionClick(4, 6);
        }

        private void pic47_Click(object sender, EventArgs e)
        {
            fActionClick(4, 7);
        }

        private void pic48_Click(object sender, EventArgs e)
        {
            fActionClick(4, 8);
        }

        private void pic51_Click(object sender, EventArgs e)
        {
            fActionClick(5, 1);
        }

        private void pic52_Click(object sender, EventArgs e)
        {
            fActionClick(5, 2);
        }

        private void pic53_Click(object sender, EventArgs e)
        {
            fActionClick(5, 3);
        }

        private void pic54_Click(object sender, EventArgs e)
        {
            fActionClick(5, 4);
        }

        private void pic55_Click(object sender, EventArgs e)
        {
            fActionClick(5, 5);
        }

        private void pic56_Click(object sender, EventArgs e)
        {
            fActionClick(5, 6);
        }

        private void pic57_Click(object sender, EventArgs e)
        {
            fActionClick(5, 7);
        }

        private void pic58_Click(object sender, EventArgs e)
        {
            fActionClick(5, 8);
        }

        private void pic61_Click(object sender, EventArgs e)
        {
            fActionClick(6, 1);
        }

        private void pic62_Click(object sender, EventArgs e)
        {
            fActionClick(6, 2);
        }

        private void pic63_Click(object sender, EventArgs e)
        {
            fActionClick(6, 3);
        }

        private void pic64_Click(object sender, EventArgs e)
        {
            fActionClick(6, 4);
        }

        private void pic65_Click(object sender, EventArgs e)
        {
            fActionClick(6, 5);
        }

        private void pic66_Click(object sender, EventArgs e)
        {
            fActionClick(6, 6);
        }

        private void pic67_Click(object sender, EventArgs e)
        {
            fActionClick(6, 7);
        }

        private void pic68_Click(object sender, EventArgs e)
        {
            fActionClick(6, 8);
        }

        private void pic71_Click(object sender, EventArgs e)
        {
            fActionClick(7, 1);
        }

        private void pic72_Click(object sender, EventArgs e)
        {
            fActionClick(7, 2);
        }

        private void pic73_Click(object sender, EventArgs e)
        {
            fActionClick(7, 3);
        }

        private void pic74_Click(object sender, EventArgs e)
        {
            fActionClick(7, 4);
        }

        private void pic75_Click(object sender, EventArgs e)
        {
            fActionClick(7, 5);
        }

        private void pic76_Click(object sender, EventArgs e)
        {
            fActionClick(7, 6);
        }

        private void pic77_Click(object sender, EventArgs e)
        {
            fActionClick(7, 7);
        }

        private void pic78_Click(object sender, EventArgs e)
        {
            fActionClick(7, 8);
        }

        private void pic81_Click(object sender, EventArgs e)
        {
            fActionClick(8, 1);
        }

        private void pic82_Click(object sender, EventArgs e)
        {
            fActionClick(8, 2);
        }

        private void pic83_Click(object sender, EventArgs e)
        {
            fActionClick(8, 3);
        }

        private void pic84_Click(object sender, EventArgs e)
        {
            fActionClick(8, 4);
        }

        private void tmrDead_Tick(object sender, EventArgs e)
        {
            _board.fSetcol(mnDeadcol);
            _board.fSetrow(mnDeadrow);
            _board.fSetwait(mnBLANK);
            _board.fWrite();
            fUpdateDisplay();
            tmrDead.Enabled = false;

        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            bool bFound = false;

            for (int i = 1; i <= mnEnemies; i++)
            {
                if (_enemies.fGetEnemyDead(i) == false)
                {
                    bFound = true;
                    continue;
                }
            }

            if (bFound == false)
            {
                Random rnd1 = new Random();
                nScore += rnd1.Next(2000, 200000);
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                fRestarts(2);

            }
        }

        private void tmrFireball_Tick(object sender, EventArgs e)
        {
            for (int i = mnFireballcol - 2; i <= mnFireballcol + 2; i++)
            {
                if (i >=1)
                {
                    if (i <= 8)
                    {
                        for (int j = mnFireballcol - 2; j <= mnFireballcol + 2; j++)
                        {
                            if (j >= 1)
                            {
                                if (j <= 30)
                                {
                                    _board.fSetcol(i);
                                    _board.fSetrow(j);
                                    if (_board.fReadType() == mnFIREBALL)
                                    {
                                        _board.fSetwait(mnBLANK);
                                        _board.fWrite();
                                    }

                                }
                            }
                        }

                    }
                }
             

            }
         
            fUpdateDisplay();
            tmrFireball.Enabled = false;

        }

        private void pic85_Click(object sender, EventArgs e)
        {
            fActionClick(8, 5);
        }

        private void pic86_Click(object sender, EventArgs e)
        {
            fActionClick(8, 6);
        }

        private void pic87_Click(object sender, EventArgs e)
        {
            fActionClick(8, 7);
        }

        private void pic88_Click(object sender, EventArgs e)
        {
            fActionClick(8, 8);
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            String sText = txtEquip.Text.Substring(0, 4);
            String s1, s2, s3, s4;
            bool bEquip1, bEquip2, bEquip3, bEquip4;

            s1 = sText.Substring(0, 1);
            s2 = sText.Substring(1, 1);
            s3 = sText.Substring(2, 1);
            s4 = sText.Substring(3, 1);

            if (s1 == "0")
            {
                bEquip1 = false;
            }
            else
            {
                bEquip1 = true;
            }
            if (s2 == "0")
            {
                bEquip2 = false;
            }
            else
            {
                bEquip2 = true;
            }
            if (s3 == "0")
            {
                bEquip3 = false;
            }
            else
            {
                bEquip3 = true;
            }
            if (s4 == "0")
            {
                bEquip4 = false;
            }
            else
            {
                bEquip4 = true;
            }
            _counter.fSetplayer4(mnPlayer, bEquip1, bEquip2, bEquip3, bEquip4);

        }

        private void btnAction1_Click(object sender, EventArgs e)
        {
           mnAction = 1;
        }

        private void fPNext()
        {
            Random rnd1 = new Random();
            String sText;
            int nHP;
            bool bSkill, bDead;
            bool bEquip1, bEquip2, bEquip3, bEquip4;

            mnPlayer = rnd1.Next(1, 7);
            mnAction = 1;
            fUpgradeyou();

            nHP = _counter.fGetHP();
            bSkill = _counter.fGetSkill();
            bDead = _counter.fGetDead();
            bEquip1 = _counter.fGetequip1();
            bEquip2 = _counter.fGetequip2();
            bEquip3 = _counter.fGetequip3();
            bEquip4 = _counter.fGetequip4();

            mnMovesleft = 9;

            fList1(mnPlayer, nHP, bSkill, bDead, bEquip1, bEquip2, bEquip3, bEquip4);

            if (lst2.Items.Count > 0)
            {
                do
                {
                    lst2.Items.RemoveAt(0);
                } while (lst2.Items.Count > 0);

            }

        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nCol, nRow;

            tmrDead.Enabled = false;
            tmrFireball.Enabled = false;

            mnCol2 = rnd1.Next(1, 9);
            mnRow2 = rnd1.Next(1, 9);
            _display.fSetcol(mnCol2);
            _display.fSetrow(mnRow2);
            lblSelected.Text = "SELECTED = " + Convert.ToString(mnCol2) + "," + Convert.ToString(mnRow2);

            mnPlayers = 6;
            mnEnemies = 20;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    _board.fSetcol(i);
                    _board.fSetrow(j);
                    _board.fSetRotate(rnd1.Next(1, 5));
                    _board.fSetwait(mnBLANK);
                    _board.fWrite();
                }
            }

            int nRotate = 0;

            nCol = 0;
            nRow = 0;
            do
            {
                nRow += 1;
                if (nRow == 1)
                {
                    nCol = rnd1.Next(1, 9);
                    _board.fSetcol(nCol);
                    _board.fSetrow(nRow);
                    nRotate = _board.fReadRotate();
                    fStick(nCol, nRow, mnSTONES - 1, nRotate);
                }
                else
                {
                    nNumber = rnd1.Next(1, 10);
                    switch (nCol)
                    {
                        case 1:
                            if (nNumber <= 4)
                            {

                            }
                            else
                            {
                                nCol = 2;
                                nNumber = rnd1.Next(1, 10);
                                if (nNumber <= 5)
                                {
                                    nRow += 1;
                                }
                            }
                            break;
                        case 8:
                            if (nNumber <= 4)
                            {

                            }
                            else
                            {
                                nCol = 7;
                                nNumber = rnd1.Next(1, 10);
                                if (nNumber <= 5)
                                {
                                    nRow += 1;
                                }
                            }
                            break;
                        default:
                            if (nNumber <= 3)
                            {
                                nCol -= 1;
                                nRow -= 1;
                            }
                            else
                            {
                                if (nNumber <= 6)
                                {
                                    nCol += 1;
                                    nRow -= 1;
                                }
                                else
                                {
                                }
                            }
                            break;
                    }
                    if (nRow == 31)
                    {

                    }
                    else
                    {
                        _board.fSetcol(nCol);
                        _board.fSetrow(nRow);
                        nRotate = _board.fReadRotate();
                        fStick(nCol, nRow, mnSTONES - 1, nRotate);
                    }
                }
            } while (nRow < 30);

            for (int i = 1; i <= mnPlayers; i++)
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 31);
                _board.fSetcol(nCol);
                _board.fSetrow(nRow);
                nRotate = _board.fReadRotate();
                _counter.fSetplayer(i);
                _counter.fSetplayer2(i, nCol, nRow);
                _counter.fSetplayer3(i, rnd1.Next(20, 61), false, false);
                _counter.fSetplayer4(i, false, false, false, false);
                fStick(nCol, nRow, mnCHARACTER, nRotate);
            }
            for (int i = 1; i <= mnEnemies; i++)
            {
                nCol = rnd1.Next(1, 9);
                nRow = rnd1.Next(1, 31);
                _board.fSetcol(nCol);
                _board.fSetrow(nRow);
                nRotate = _board.fReadRotate();
                _enemies.fSetenemy(i);
                _enemies.fSetenemies2(i, nCol, nRow);
                _enemies.fSetenemies3(i, rnd1.Next(20, 61), false, false);
                fStick(nCol, nRow, mnENEMY, nRotate);
            }

        }


        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F blank2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F bush.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F EnemyCharacter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F EnemySelected.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F fireballsuccess.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F fruits1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F fruits2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F holdpersonsuccess.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F PersonDying.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F road.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F stones_intheway.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F stonewall.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F YOUCharacter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F YOUSelected.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                case 12:
                    _pic2 = picture12;
                    break;
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                case 16:
                    _pic2 = picture16;
                    break;
                default:
                    _pic2 = picture17;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    _display.fSetcol(i);
                    _display.fSetrow(j);
                    nType = _display.fReadType();
                    nRotate = _display.fReadRotate();
                    fPeek(nType, nRotate, ref _pic);
                    switch (i)
                    {
                        case 1:
                            switch (j)
                            {
                                case 1:
                                    pic11.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic12.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic13.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic14.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic15.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic16.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic17.Image = _pic.Image;
                                    break;
                                default:
                                    pic18.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 2:
                            switch (j)
                            {
                                case 1:
                                    pic21.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic22.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic23.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic24.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic25.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic26.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic27.Image = _pic.Image;
                                    break;
                                default:
                                    pic28.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 3:
                            switch (j)
                            {
                                case 1:
                                    pic31.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic32.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic33.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic34.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic35.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic36.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic37.Image = _pic.Image;
                                    break;
                                default:
                                    pic38.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 4:
                            switch (j)
                            {
                                case 1:
                                    pic41.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic42.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic43.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic44.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic45.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic46.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic47.Image = _pic.Image;
                                    break;
                                default:
                                    pic48.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 5:
                            switch (j)
                            {
                                case 1:
                                    pic51.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic52.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic53.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic54.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic55.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic56.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic57.Image = _pic.Image;
                                    break;
                                default:
                                    pic58.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 6:
                            switch (j)
                            {
                                case 1:
                                    pic61.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic62.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic63.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic64.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic65.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic66.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic67.Image = _pic.Image;
                                    break;
                                default:
                                    pic68.Image = _pic.Image;
                                    break;
                            }
                            break;
                        case 7:
                            switch (j)
                            {
                                case 1:
                                    pic71.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic72.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic73.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic74.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic75.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic76.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic77.Image = _pic.Image;
                                    break;
                                default:
                                    pic78.Image = _pic.Image;
                                    break;
                            }
                            break;
                        default:
                            switch (j)
                            {
                                case 1:
                                    pic81.Image = _pic.Image;
                                    break;
                                case 2:
                                    pic82.Image = _pic.Image;
                                    break;
                                case 3:
                                    pic83.Image = _pic.Image;
                                    break;
                                case 4:
                                    pic84.Image = _pic.Image;
                                    break;
                                case 5:
                                    pic85.Image = _pic.Image;
                                    break;
                                case 6:
                                    pic86.Image = _pic.Image;
                                    break;
                                case 7:
                                    pic87.Image = _pic.Image;
                                    break;
                                default:
                                    pic88.Image = _pic.Image;
                                    break;
                            }
                            break;
                    }
                }
            }
        }

        private void fCopy()
        {
            int nRow, nType, nRotate;

            for (int i = 1; i <= 8; i++)
            {
                nRow = 0;
                for (int j = mnModeSquareRow; j >= mnModeSquareRow - 7; j--)
                {
                    nRow += 1;
                    _board.fSetcol(i);
                    _board.fSetrow(j);
                    if (j > 30)
                    {
                        nType = mnNULLGATE;
                        nRotate = 1;
                    }
                    else
                    {
                        if (j < 1)
                        {
                            nType = mnNULLGATE;
                            nRotate = 1;
                        }
                        else
                        {
                            nType = _board.fReadType();
                            nRotate = _board.fReadRotate();
                        }
                    }
                    _display.fSetcol(i);
                    _display.fSetrow(nRow);
                    _display.fSetRotate(nRotate);
                    _display.fSetwait(nType);
                    _display.fWrite();
                }


            }

        }

        private void fRestarts(int nMode)
        {
            Random rnd1 = new Random();
            mnModeSquareRow = rnd1.Next(8, 31);
            lblRow.Text = "Row " + Convert.ToString(mnModeSquareRow) + "/30";
            fReset();
            fPNext();
            fCopy();
            fUpdateDisplay();
            lblRow1a.Text = Convert.ToString(mnModeSquareRow);
            lblRow1b.Text = Convert.ToString(mnModeSquareRow);
            lblRow8a.Text = Convert.ToString(mnModeSquareRow - 7);
            lblRow8b.Text = Convert.ToString(mnModeSquareRow - 7);
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fRestarts(2);
        }

        public fSub1()
        {
            InitializeComponent();
            nScore = 0;
            lblScore.Text = "Score = 0";
        }

        private void btnUpgrade1_Click(object sender, EventArgs e)
        {
            fUpgrade(1);
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fRestarts(1);
        }

    }
}
