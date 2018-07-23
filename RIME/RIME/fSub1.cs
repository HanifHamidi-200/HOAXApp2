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

namespace RIME
{
    public partial class fSub1 : Form
    {
        private List<String> _data1 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _data2 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _data3 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<String> _data4 = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private List<int> _count = new List<int> { 0, 0, 0, 0 };
        private int mnQuestion, mnPos;
        private String sInput1, sInput2;
        private int mnData, mnDataCurrent;
        private int nScore;

        private void fReset()
        {
            bool bError = false;
            fGetDatabase("F michael.txt", ref bError);
        }
        private void fGetDatabase(String sName, ref bool bError)
        {


            int nCount = 0;
            String sLine;
            String sBuffer = null;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    mnData = 1;
                    do
                    {
                        sLine = sr.ReadLine();
                        if (sLine.Length >= 4)
                        {
                            if (sLine.Substring(0, 4) == "LIST")
                            {
                                sBuffer = "LIST";
                            }
                            else
                            {
                                sBuffer = null;
                            }
                        }
                        else
                        {
                            sBuffer = null;
                        }
                        if (sBuffer == "LIST")
                        {
                            _count[mnData - 1] = nCount;
                            mnData += 1;
                            nCount = 0;
                        }
                        else
                        {
                            nCount += 1;
                            switch (mnData)
                            {
                                case 1:
                                    _data1[nCount - 1] = sLine;
                                    break;
                                case 2:
                                    _data2[nCount - 1] = sLine;
                                    break;
                                case 3:
                                    _data3[nCount - 1] = sLine;
                                    break;
                                default:
                                    _data4[nCount - 1] = sLine;
                                    break;
                            }
                        }
                    } while (sr.EndOfStream == false);
                }
                bError = false;
                _count[mnData - 1] = nCount;
                fQNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! = " + ex);
                bError = true;
                _count[mnData - 1] = 0;
            }
        }

        private void fUpdateStatus()
        {
            lblRecord.Text = "Record = [" + Convert.ToString(mnDataCurrent) + "," + Convert.ToString(mnQuestion) + "]";
            lblScore.Text = "Score = " + Convert.ToString(nScore);
        }
        private void fQNext()
        {
            Random rnd1 = new Random();
            String sText;

            mnDataCurrent = rnd1.Next(1, mnData + 1);

            if (_count[mnDataCurrent - 1] == 0)
            {
                return;
            }

            mnQuestion = rnd1.Next(1, _count[mnDataCurrent - 1] + 1);
            mnPos = 1;
            switch (mnDataCurrent)
            {
                case 1:
                    sText = _data1[mnQuestion - 1];
                    break;
                case 2:
                    sText = _data2[mnQuestion - 1];
                    break;
                case 3:
                    sText = _data3[mnQuestion - 1];
                    break;
                default:
                    sText = _data4[mnQuestion - 1];
                    break;
            }
            txtAnswer1.Text = sText;
            txtAnswer2.Text = null;
            txtTypos1.Text = null;
            txtTypos2.Text = null;
            fUpdateStatus();
        }

        public fSub1()
        {
            InitializeComponent();
            nScore = 0;
            lblScore.Text = "Score = 0";
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fQNext();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            bool bError = false;
            fGetDatabase(txtDatabase.Text, ref bError);
        }

        private void txtTypos1_KeyUp(object sender, KeyEventArgs e)
        {
            char sLetter = (char)(e.KeyValue);
            String sExpected;
            String sText;

            if (sLetter <= 'a')
            {
                if (txtAnswer1.Text.ToUpper() == txtAnswer2.Text.ToUpper())
                {
                    nScore += 10;
                    fUpdateStatus();
                    fQNext();
                    return;
                }
            }

            switch (mnDataCurrent)
            {
                case 1:
                    sText = _data1[mnQuestion - 1];
                    break;
                case 2:
                    sText = _data2[mnQuestion - 1];
                    break;
                case 3:
                    sText = _data3[mnQuestion - 1];
                    break;
                default:
                    sText = _data4[mnQuestion - 1];
                    break;
            }

            sExpected = sText.Substring(mnPos - 1, 1);

            sInput1 = Convert.ToString(sLetter);

            txtTypos1.Text = sInput1;

            if (sInput1.ToUpper() == sExpected.ToUpper())
            {
                mnPos += 1;
                txtAnswer2.Text = txtAnswer2.Text + sInput1;
            }
            else
            {
                txtTypos2.Text = txtTypos2.Text + sInput1;
            }
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}