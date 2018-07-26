using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private cStudyPath _studypath = new cStudyPath();
        private int mnMove;
        private bool mbTurn;
        private int mnRestart;
        private int mnAutoLevel;
        private bool mbDB, mbAI;
        private int nNumber;
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
            Random rnd1=new Random();
            bool bError = false;
            String sStringcode = _StringCode.fGet();
            int nType = Convert.ToInt16(sStringcode.Substring( nSquare - 1,1));
            int nNew=0;

            nNumber = rnd1.Next(1, 10);
            if (mnMove == 0)
            {
                bAbort = true;
                return;
            }
            if (nType == 0)
            {
                if (mbTurn)
                {
                    nNew = 1;
                }
                else {
                    nNew = 2;
                 }
            }
            else
            {
                     bAbort = true;
          
            }

            if (bAbort)
            {
                MessageBox.Show("Error!");
                return;
            }

             _StringCode.fPush(Convert.ToString(nNew), nSquare , ref bError);
            _MoveCode.fPush(Convert.ToString(nSquare),  ref bError);
            fUpdateDisplay();
            fExamine();
            if (mbTurn)
            {
                fRotateTurn();
            }

            if (mbAI)
            {
                if (nNumber <= 2)
                {
                    nSquare = fMoveAuto(ref bAbort);
                    nNumber = rnd1.Next(1, 10);
                    if (mnMove == 0)
                    {
                        bAbort = true;
                        return;
                    }
                    if (nType == 0)
                    {
                        if (mbTurn)
                        {
                            nNew = 1;
                        }
                        else
                        {
                            nNew = 2;
                        }
                    }
                    else
                    {
                        bAbort = true;

                    }

                    if (bAbort)
                    {
                        MessageBox.Show("Error!");
                        return;
                    }
                    _StringCode.fPush(Convert.ToString(nNew), nSquare, ref bError);
                    _MoveCode.fPush(Convert.ToString(nSquare), ref bError);
                    fUpdateDisplay();
                    fExamine();
                    if (mbTurn)
                    {
                        fRotateTurn();
                    }
                }
            }
        }

        private int fMoveAuto( ref bool bAbort)
        {
            Random rnd1 = new Random();
            bool bFound = false;
             String sStringCode = _StringCode.fGet();
            int nAnswer=0;
            bool bAbort2 = false;
            int nSquare = 0;

            switch (mnAutoLevel)
            {
                case 1:
                    do
                    {
                        nSquare = rnd1.Next(1, 10);
                        if (sStringCode.Substring(nSquare - 1, 1) != "0")
                        {

                        }
                        else
                        {
                            bFound = true;
                            nAnswer = nSquare;
                        }
                    } while (bFound == false);
                    break;
                case 2:
                    nAnswer=_Level2.fResponse(sStringCode);
                    if (nAnswer == 0)
                    {
                        do
                        {
                            nSquare = rnd1.Next(1, 10);
                            if (sStringCode.Substring(nSquare - 1, 1) != "0")
                            {

                            }
                            else
                            {
                                bFound = true;
                                nAnswer = nSquare;
                            }
                        } while (bFound == false);
                        break;

                    }
                    
                    break;
                case 3:
                    break;
                default:
                    break;
            }

           bAbort = bAbort2;
            return nAnswer;
         }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F bestfit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F changelings.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F condonement.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F empty.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F helptips.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F mediaplay.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
             PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F O.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F Owin.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F relagations.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F suggested.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F turnip.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F willynilly.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F X.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F Xwin.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
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
                default:
                    _pic2 = picture15;
                    break;
            }
           
        }

        private int fTypecos(int nType)
        {
            switch (nType)
            {
                case 1:
                    return 13;
                case 2:
                    return 7;
                default:
                    return 4;
             }
        }
        private void fUpdateDisplay()
        {
            int nType, nRotate;
            PictureBox _pic = new PictureBox();
            String sStringcode;

            sStringcode = _StringCode.fGet();
            nRotate = 1;

            nType = Convert.ToInt32(sStringcode.Substring(0, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic1.Image = _pic.Image;
            nType = Convert.ToInt32(sStringcode.Substring(1, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic2.Image = _pic.Image;
            nType = Convert.ToInt32(sStringcode.Substring(2, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic3.Image = _pic.Image;
            nType = Convert.ToInt32(sStringcode.Substring(3, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic4.Image = _pic.Image;
            nType = Convert.ToInt32(sStringcode.Substring(4, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic5.Image = _pic.Image;
            nType = Convert.ToInt32(sStringcode.Substring(5, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic6.Image = _pic.Image;
            nType = Convert.ToInt32(sStringcode.Substring(6, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic7.Image = _pic.Image;
            nType = Convert.ToInt32(sStringcode.Substring(7, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic8.Image = _pic.Image;
            nType = Convert.ToInt32(sStringcode.Substring(8, 1));
            nType = fTypecos(nType);
            fPeek(nType, nRotate, ref _pic);
            pic9.Image = _pic.Image;

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
       
        }

        private void fExamine()
        {
            String sExamine;
   
            if (!mbTurn)
            {
                sExamine = "Examine = 'YOU turn'";
                lblExamine.Text = sExamine;

            }
            else
            {
                sExamine = "Examine = 'AUTO turn'";
                lblExamine.Text = sExamine;
           }
        }

        private void fRotateTurn()
        {
            if (mbTurn)
            {
                mbTurn = false;
            }
            else
            {
                mbTurn = true;
            }
            mnMove += 1;
            if (mnMove == 10)
            {
                MessageBox.Show("Error!");
                return;
            }
        }
        private void fRestart()
        {
            int nMode = _YOUCharacter.fGetMode();
            String sExamine = null;
            int nItem, nRotate;
            String sStringcode,sMovecode;

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

                    fStudyPath _dlg = new fStudyPath();
                    _dlg.ShowDialog();
                    String sName = "dlg.txt";
                     String sLine;

                    try
                    {   // Open the text file using a stream reader.
                        using (StreamReader sr = new StreamReader(sName))
                        {
                            // Read the stream to a string, and write the string to the console.
                            sLine = sr.ReadLine();
                            nItem = Convert.ToInt32(sLine);
                            sLine = sr.ReadLine();
                            nRotate = Convert.ToInt32(sLine);
                        }
                        _studypath.fSet(nItem, nRotate);
                        sMovecode = _studypath.fTranscribe1();
                        sMovecode = _studypath.fTranscribe2(sMovecode);
                        sStringcode = _studypath.fTranscribe3();
                        sStringcode = _studypath.fTranscribe4();
                        _MoveCode.fSet(sMovecode);
                        _StringCode.fSet(sStringcode);
                        mnMove = 2;
                        if (mbTurn)
                        {
                            mbTurn = false;
                        }
                        else
                        {
                            mbTurn = true;
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("The file could not be read:", e1.Message);
                        fReset();
                    }
               
            fUpdateDisplay();
            fExamine();
        }

        public fSub1()
        {
            InitializeComponent();
            mnAutoLevel = 2;
        }

        private void fSub1_Load(object sender, EventArgs e)
        {

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

        private void btnYOU1_Click(object sender, EventArgs e)
        {
            _YOUCharacter.fSetMode(1);

        }

        private void btnYOU2_Click(object sender, EventArgs e)
        {
            _YOUCharacter.fSetMode(2);

        }

        private void btnYOU3_Click(object sender, EventArgs e)
        {
            _YOUCharacter.fSetMode(3);

        }

        private void btnRestart1_Click(object sender, EventArgs e)
        {
            mnRestart = 1;
            fRestart();
        }

        private void btnRestart2_Click(object sender, EventArgs e)
        {
            mnRestart = 2;
            mbDB = false;
            mbAI = true;
            fRestart();

        }

        private void btnRestart3_Click(object sender, EventArgs e)
        {
            mnRestart = 3;
            fRestart();

        }

        private void btnRestart4_Click(object sender, EventArgs e)
        {
            mnRestart = 4;
            mbDB = true;
            mbAI = false;
            fRestart();

        }

        private void btnRestart5_Click(object sender, EventArgs e)
        {
            mnRestart = 5;
            mbDB = true;
            mbAI = true;
            fRestart();

        }

        private void btnRestart6_Click(object sender, EventArgs e)
        {
            mnRestart = 6;
            fRestart();

        }

        private void btnRestart7_Click(object sender, EventArgs e)
        {
            mnRestart = 7;
            fRestart();

        }

        private void btnRestart8_Click(object sender, EventArgs e)
        {
            mnRestart = 8;
            mbDB = false;
            mbAI = false;
            fRestart();

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                fMove(1, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
          }

        private void pic2_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                 fMove(2, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
        
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                 fMove(3, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
        
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                 fMove(4, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
       
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                  fMove(5, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
      
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                  fMove(6, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
         
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                 fMove(7, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
      
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                fMove(8, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
       
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            bool bAbort = false;

                fMove(9, ref bAbort);
                if (!bAbort)
                {
                    fRotateTurn();
                }
                 }
    }
}
