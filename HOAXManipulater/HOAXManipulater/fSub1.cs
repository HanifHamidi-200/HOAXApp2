using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAXManipulater
{
    public partial class fSub1 : Form
    {
        private cBoard _Board = new cBoard();
        private cLevel2 _Level2 = new cLevel2();
        private cLevel3 _Level3 = new cLevel3();
        private cLevel4 _Level4 = new cLevel4();
        private cMoveCode _MoveCode = new cMoveCode();
        private cRotateNumber _RotateNumber = new cRotateNumber();
        private cStringCode _StringCode = new cStringCode();
        private cTryItem _TryItem = new cTryItem();
        private cYOUCharacter _YOUCharacter = new cYOUCharacter();
        private int mnMove;
        private bool mbTurn;


        private bool fCheck(String sCode)
        {
            String sText = _StringCode.fGet();
            int nPos1 = Convert.ToInt32(sCode.Substring(0, 1));
            int nPos2 = Convert.ToInt32(sCode.Substring(1, 1));
            int nPos3 = Convert.ToInt32(sCode.Substring(2, 1));

             if (sText.Substring(nPos1 - 1,1) == "1")
            {
                if (sText.Substring(nPos2 - 1,1) == "1")
                {
                    if (sText.Substring(nPos3 - 1,1) == "1")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool fCheck2(String sCode)
        {
            String sText = _StringCode.fGet();
            int nPos1 = Convert.ToInt32(sCode.Substring(0, 1));
            int nPos2 = Convert.ToInt32(sCode.Substring(1, 1));
            int nPos3 = Convert.ToInt32(sCode.Substring(2, 1));

            if (sText.Substring(nPos1 - 1) == "2")
            {
                if (sText.Substring(nPos2 - 1) == "2")
                {
                    if (sText.Substring(nPos3 - 1) == "2")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void fMove(int nSquare, ref bool bAbort)
        {
            int nGo=0;
            bool bError = false;

            switch (nSquare)
            {
                case 1:
                    if (btn1.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn1.Text = "X";
                    nGo = 1;
                    break;
                case 2:
                    if (btn2.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn2.Text = "X";
                    nGo = 2;
                    break;
                case 3:
                    if (btn3.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn3.Text = "X";
                    nGo = 3;
                    break;
                case 4:
                    if (btn4.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn4.Text = "X";
                    nGo = 4;
                    break;
                case 5:
                    if (btn5.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn5.Text = "X";
                    nGo = 5;
                    break;
                case 6:
                    if (btn6.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn6.Text = "X";
                    nGo = 6;
                    break;
                case 7:
                    if (btn7.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn7.Text = "X";
                    nGo = 7;
                    break;
                case 8:
                    if (btn8.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn8.Text = "X";
                    nGo = 8;
                    break;
                default:
                    if (btn9.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn9.Text = "X";
                    nGo = 9;
                    break;
            }

            mnMove++;
            _StringCode.fPush("1", mnMove, ref bError);
            _MoveCode.fPush(Convert.ToString(nGo),  ref bError);
        }
        private void fMoveAuto(int nSquare, ref bool bAbort)
        {
            int nGo = 0;
            bool bError = false;

            switch (nSquare)
            {
                case 1:
                    if (btn1.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn1.Text = "O";
                    nGo = 1;
                    break;
                case 2:
                    if (btn2.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn2.Text = "O";
                    nGo = 2;
                    break;
                case 3:
                    if (btn3.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn3.Text = "O";
                    nGo = 3;
                    break;
                case 4:
                    if (btn4.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn4.Text = "O";
                    nGo = 4;
                    break;
                case 5:
                    if (btn5.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn5.Text = "O";
                    nGo = 5;
                    break;
                case 6:
                    if (btn6.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn6.Text = "O";
                    nGo = 6;
                    break;
                case 7:
                    if (btn7.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn7.Text = "O";
                    nGo = 7;
                    break;
                case 8:
                    if (btn8.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn8.Text = "O";
                    nGo = 8;
                    break;
                default:
                    if (btn9.Text != "[-]")
                    {
                        bAbort = true;
                        return;
                    }
                    btn9.Text = "O";
                    nGo = 9;
                    break;
            }

            mnMove++;
            _StringCode.fPush("2", mnMove, ref bError);
            _MoveCode.fPush(Convert.ToString(nGo), ref bError);
        }

        private void fReset()
        {
            lblExamine.Text = null;
            if (lstExamine.Items.Count > 0)
            {
                do
                {
                    lstExamine.Items.RemoveAt(0);
                } while (lstExamine.Items.Count > 0);
            }
            btn1.Text = "[-]";
            btn2.Text = "[-]";
            btn3.Text = "[-]";
            btn4.Text = "[-]";
            btn5.Text = "[-]";
            btn6.Text = "[-]";
            btn7.Text = "[-]";
            btn8.Text = "[-]";
            btn9.Text = "[-]";


        }
        private void fRestart()
        {
            int nMode = _YOUCharacter.fGetMode();
            String sExamine = null;

            fReset();
            _StringCode.fInit();
            _MoveCode.fInit();

            switch (nMode)
            {
                case 1:
                    sExamine = "Examine = 'YOU start'";
                    mnMove = 0;
                    mbTurn = true;
                    break;
                case 2:
                    sExamine = "Examine = 'AUTO start'";
                    mnMove = 0;
                    mbTurn = false;
                    break;
                default:
                    sExamine = "Examine = 'AUTO start'";
                    mnMove = 0;
                    mbTurn = false;
                    break;
            }

            lblExamine.Text = sExamine;
        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {

        }

        private void btnRestart1_Click(object sender, EventArgs e)
        {
            _YOUCharacter.fSetMode(1);
            fRestart();
        }

        private void btnRestart2_Click(object sender, EventArgs e)
        {
            _YOUCharacter.fSetMode(2);
            fRestart();
        }

        private void btnRestart3_Click(object sender, EventArgs e)
        {
            _YOUCharacter.fSetMode(3);
            fRestart();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(1, ref bAbort);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bool bAbort = false;
            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(2, ref bAbort);
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            bool bAbort = false;
            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(3, ref bAbort);
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            bool bAbort = false;
            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(4, ref bAbort);
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            bool bAbort = false;
            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(5, ref bAbort);
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            bool bAbort = false;
            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(6, ref bAbort);
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            bool bAbort = false;
            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(7, ref bAbort);
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            bool bAbort = false;
            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(8, ref bAbort);
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            bool bAbort = false;
            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(9, ref bAbort);
            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            bool bAbort = false;

            if (mbTurn == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                fMove(rnd1.Next(1, 10), ref bAbort);
            }

        }


        private void btnComply_Click(object sender, EventArgs e)
        {
            bool bFound = false;
          
            for (int i = 1; i <= 8; i++)
            {
                switch (i)
                {
                    case 1:
                        bFound = fCheck("147");
                        break;
                    case 2:
                        bFound = fCheck("258");
                        break;
                    case 3:
                        bFound = fCheck("369");
                        break;
                    case 4:
                        bFound = fCheck("123");
                        break;
                    case 5:
                        bFound = fCheck("456");
                        break;
                    case 6:
                        bFound = fCheck("789");
                        break;
                    case 7:
                        bFound = fCheck("159");
                        break;
                    default:
                        bFound = fCheck("357");
                        break;
                }
                if (bFound)
                {
                    MessageBox.Show("Player1 wins!");
                    fReset();
                    return;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                switch (i)
                {
                    case 1:
                        bFound = fCheck2("147");
                        break;
                    case 2:
                        bFound = fCheck2("258");
                        break;
                    case 3:
                        bFound = fCheck2("369");
                        break;
                    case 4:
                        bFound = fCheck2("123");
                        break;
                    case 5:
                        bFound = fCheck2("456");
                        break;
                    case 6:
                        bFound = fCheck2("789");
                        break;
                    case 7:
                        bFound = fCheck2("159");
                        break;
                    default:
                        bFound = fCheck2("357");
                        break;
                }
                if (bFound)
                {
                    MessageBox.Show("Player2 wins!");
                    fReset();
                    return;
                }
            }
        }
    }
}
