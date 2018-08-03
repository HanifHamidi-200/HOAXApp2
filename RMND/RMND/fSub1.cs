using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RMND
{
    public partial class fSub1 : Form
    {
        private List<String> _list = new List<String> { null, null, null, null, null, null, null, null, null };
        private int mnFiles;
        private cSudoku _sudoku1 = new cSudoku();
        private cSudoku _sudoku2 = new cSudoku();
        private int mnPuzzle, mnCol, mnRow;

        private void fGet(int nPuzzle)
        {
            String sName = "F data.txt";
            String sLine;
            int nPuzzle2;
            bool bOut = false;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    mnFiles = Convert.ToInt32(sLine);
                    nPuzzle2 = 0;
                    do
                    {
                        sLine = sr.ReadLine();
                        if (sLine == "END")
                        {
                            bOut = true;
                            continue;
                        }
                        nPuzzle2 += 1;
                        for (int i = 1; i <= 9; i++)
                        {
                            sLine = sr.ReadLine();
                            _list[i - 1] = sLine;
                        }
                        if (nPuzzle2 == nPuzzle)
                        {
                            return;
                        }
                    } while (sr.EndOfStream == false);
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }
        }

        private void fPopulate(int nPuzzle)
        {
            String sText = null;

            switch (nPuzzle)
            {
                case 1:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            sText = _list[i - 1].Substring(j - 1, 1);
                            _sudoku1.fSet(i, j, Convert.ToInt32(sText));
                        }
                    }
                    break;

                default:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            sText = _list[i - 1].Substring(j - 1, 1);
                            _sudoku2.fSet(i, j, Convert.ToInt32(sText));
                        }
                    }
                    break;
            }
        }

        private void fUpdateStatus()
        {
            lblPuzzle.Text = "mnPuzzle (/2) = " + Convert.ToString(mnPuzzle);
            lblCol.Text = "mnCol (/9) = " + Convert.ToString(mnCol);

        }
        private void fReset()
        {
            String sText;

            mnPuzzle = 1;
            mnCol = 1;
            mnRow = 1;
            fUpdateStatus();

            if (lstShow1.Items.Count > 0)
            {
                do
                {
                    lstShow1.Items.RemoveAt(0);
                } while (lstShow1.Items.Count > 0);
            }
            if (lstShow2.Items.Count > 0)
            {
                do
                {
                    lstShow2.Items.RemoveAt(0);
                } while (lstShow2.Items.Count > 0);
            }

            fGet(1);
            fPopulate(1);
            btnShow1.Text = "SHOW" + Convert.ToString("1") + "/" + Convert.ToString(mnFiles);
            for (int i = 1; i <= 9; i++)
            {
                sText = _list[i - 1];
                lstShow1.Items.Add(sText);
            }
            fGet(2);
            fPopulate(2);
            btnShow2.Text = "SHOW" + Convert.ToString("2") + "/" + Convert.ToString(mnFiles);
            for (int i = 1; i <= 9; i++)
            {
                sText = _list[i - 1];
                lstShow2.Items.Add(sText);
            }
        }
        public fSub1()
        {
            InitializeComponent();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            int nReturn;

            if (txtRow.Text == null)
            {
                mnRow = 1;
            }
            else
            {
                mnRow = Convert.ToInt32(txtRow.Text);
                if (mnRow < 1)
                {
                    mnRow = 1;
                }
                if (mnRow > 9)
                {
                    mnRow = 9;
                }
            }

            if (mnPuzzle == 1)
            {
                _sudoku1.fSet2(mnCol, mnRow);
                nReturn = _sudoku1.fGet();
                MessageBox.Show(Convert.ToString(nReturn), "Inside " + Convert.ToString(mnCol) + Convert.ToString(mnRow));
            }
            else
            {
                _sudoku2.fSet2(mnCol, mnRow);
                nReturn = _sudoku2.fGet();
                MessageBox.Show(Convert.ToString(nReturn), "Inside " + Convert.ToString(mnCol) + Convert.ToString(mnRow));
            }
        }

        private void lstShow1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstShow1_Click(object sender, EventArgs e)
        {
            mnPuzzle = 1;
            mnCol = lstShow1.SelectedIndex + 1;
            fUpdateStatus();
        }

        private void lstShow2_Click(object sender, EventArgs e)
        {
            mnPuzzle = 2;
            mnCol = lstShow2.SelectedIndex + 1;
            fUpdateStatus();

        }

        private void btnCount1_Click(object sender, EventArgs e)
        {
            int nTotal = 0;
            int nReturn;

            if (txtRow.Text == null)
            {
                mnRow = 1;
            }
            else
            {
                mnRow = Convert.ToInt32(txtRow.Text);
                if (mnRow < 1)
                {
                    mnRow = 1;
                }
                if (mnRow > 9)
                {
                    mnRow = 9;
                }
            }

            if (mnPuzzle == 1)
            {
                for (int i = 1; i <= 9; i++)
                {
                    _sudoku1.fSet2(mnCol, i);
                    nReturn = _sudoku1.fGet();
                    nTotal += nReturn;
                }
                MessageBox.Show(Convert.ToString(nTotal), "Col " + Convert.ToString(mnCol));

            }
            else
            {
                for (int i = 1; i <= 9; i++)
                {
                    _sudoku2.fSet2(mnCol, i);
                    nReturn = _sudoku2.fGet();
                    nTotal += nReturn;
                }
                MessageBox.Show(Convert.ToString(nTotal), "Col " + Convert.ToString(mnCol));

            }
        }

        private void btnCount2_Click(object sender, EventArgs e)
        {
            int nTotal = 0;
            int nReturn;

            if (txtRow.Text == null)
            {
                mnRow = 1;
            }
            else
            {
                mnRow = Convert.ToInt32(txtRow.Text);
                if (mnRow < 1)
                {
                    mnRow = 1;
                }
                if (mnRow > 9)
                {
                    mnRow = 9;
                }
            }

            if (mnPuzzle == 1)
            {
                for (int i = 1; i <= 9; i++)
                {
                    _sudoku1.fSet2(i, mnRow);
                    nReturn = _sudoku1.fGet();
                    nTotal += nReturn;
                }
                MessageBox.Show(Convert.ToString(nTotal), "Row " + Convert.ToString(mnRow));

            }
            else
            {
                for (int i = 1; i <= 9; i++)
                {
                    _sudoku2.fSet2(i, mnRow);
                    nReturn = _sudoku2.fGet();
                    nTotal += nReturn;
                }
                MessageBox.Show(Convert.ToString(nTotal), "Row " + Convert.ToString(mnRow));

            }
        }

        private void btnCount3_Click(object sender, EventArgs e)
        {
            int nTotal = 0;
            int nReturn;

            if (txtRow.Text == null)
            {
                mnRow = 1;
            }
            else
            {
                mnRow = Convert.ToInt32(txtRow.Text);
                if (mnRow < 1)
                {
                    mnRow = 1;
                }
                if (mnRow > 9)
                {
                    mnRow = 9;
                }
            }

            if (mnPuzzle == 1)
            {


                if (mnCol <= 3)
                {
                    if (mnRow <= 3)
                    {
                        _sudoku1.fSet2(1, 1);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;
                        _sudoku1.fSet2(1, 2);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;
                        _sudoku1.fSet2(1, 3);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;
                        _sudoku1.fSet2(2, 1);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;
                        _sudoku1.fSet2(2, 2);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;
                        _sudoku1.fSet2(2, 3);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;
                        _sudoku1.fSet2(3, 1);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;
                        _sudoku1.fSet2(3, 2);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;
                        _sudoku1.fSet2(3, 3);
                        nReturn = _sudoku1.fGet();
                        nTotal += nReturn;


                    }
                    else
                    {
                        if (mnRow <= 6)
                        {
                            _sudoku1.fSet2(1, 4);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(1, 5);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(1, 6);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(2, 4);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(2, 5);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(2, 6);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(3, 4);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(3, 5);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(3, 6);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;

                        }
                        else
                        {
                            _sudoku1.fSet2(1, 7);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(1, 8);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(1, 9);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(2, 7);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(2, 8);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(2, 9);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(3, 7);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(3, 8);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(3, 9);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;

                        }
                    }
                }
                else
                {
                    if (mnCol <= 6)
                    {
                        if (mnRow <= 3)
                        {


                            _sudoku1.fSet2(4, 1);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(4, 2);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(4, 3);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(5, 1);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(5, 2);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(5, 3);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(6, 1);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(6, 2);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(6, 3);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                        }
                        else
                        {
                            if (mnRow <= 6)
                            {
                                _sudoku1.fSet2(4, 4);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(4, 5);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(4, 6);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(5, 4);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(5, 5);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(5, 6);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(6, 4);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(6, 5);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(6, 6);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;

                            }
                            else
                            {
                                _sudoku1.fSet2(4, 7);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(4, 8);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(4, 9);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(5, 7);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(5, 8);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(5, 9);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(6, 7);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(6, 8);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(6, 9);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;

                            }
                        }

                    }
                    else
                    {
                        if (mnRow <= 3)
                        {
                            _sudoku1.fSet2(7, 1);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(7, 2);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(7, 3);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(8, 1);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(8, 2);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(8, 3);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(9, 1);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(9, 2);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;
                            _sudoku1.fSet2(9, 3);
                            nReturn = _sudoku1.fGet();
                            nTotal += nReturn;

                        }
                        else
                        {
                            if (mnRow <= 6)
                            {
                                _sudoku1.fSet2(7, 4);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(7, 5);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(7, 6);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(8, 4);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(8, 5);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(8, 6);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(9, 4);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(9, 5);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(9, 6);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;

                            }
                            else
                            {
                                _sudoku1.fSet2(7, 7);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(7, 8);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(7, 9);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(8, 7);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(8, 8);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(8, 9);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(9, 7);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(9, 8);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;
                                _sudoku1.fSet2(9, 9);
                                nReturn = _sudoku1.fGet();
                                nTotal += nReturn;

                            }
                        }
                    }
                }
            }
            else
            {


                if (mnCol <= 3)
                {
                    if (mnRow <= 3)
                    {
                        _sudoku2.fSet2(1, 1);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;
                        _sudoku2.fSet2(1, 2);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;
                        _sudoku2.fSet2(1, 3);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;
                        _sudoku2.fSet2(2, 1);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;
                        _sudoku2.fSet2(2, 2);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;
                        _sudoku2.fSet2(2, 3);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;
                        _sudoku2.fSet2(3, 1);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;
                        _sudoku2.fSet2(3, 2);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;
                        _sudoku2.fSet2(3, 3);
                        nReturn = _sudoku2.fGet();
                        nTotal += nReturn;


                    }
                    else
                    {
                        if (mnRow <= 6)
                        {
                            _sudoku2.fSet2(1, 4);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(1, 5);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(1, 6);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(2, 4);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(2, 5);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(2, 6);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(3, 4);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(3, 5);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(3, 6);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;

                        }
                        else
                        {
                            _sudoku2.fSet2(1, 7);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(1, 8);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(1, 9);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(2, 7);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(2, 8);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(2, 9);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(3, 7);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(3, 8);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(3, 9);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;

                        }
                    }
                }
                else
                {
                    if (mnCol <= 6)
                    {
                        if (mnRow <= 3)
                        {


                            _sudoku2.fSet2(4, 1);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(4, 2);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(4, 3);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(5, 1);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(5, 2);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(5, 3);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(6, 1);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(6, 2);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(6, 3);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                        }
                        else
                        {
                            if (mnRow <= 6)
                            {
                                _sudoku2.fSet2(4, 4);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(4, 5);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(4, 6);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(5, 4);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(5, 5);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(5, 6);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(6, 4);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(6, 5);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(6, 6);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;

                            }
                            else
                            {
                                _sudoku2.fSet2(4, 7);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(4, 8);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(4, 9);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(5, 7);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(5, 8);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(5, 9);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(6, 7);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(6, 8);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(6, 9);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;

                            }
                        }

                    }
                    else
                    {
                        if (mnRow <= 3)
                        {
                            _sudoku2.fSet2(7, 1);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(7, 2);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(7, 3);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(8, 1);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(8, 2);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(8, 3);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(9, 1);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(9, 2);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;
                            _sudoku2.fSet2(9, 3);
                            nReturn = _sudoku2.fGet();
                            nTotal += nReturn;

                        }
                        else
                        {
                            if (mnRow <= 6)
                            {
                                _sudoku2.fSet2(7, 4);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(7, 5);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(7, 6);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(8, 4);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(8, 5);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(8, 6);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(9, 4);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(9, 5);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(9, 6);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;

                            }
                            else
                            {
                                _sudoku2.fSet2(7, 7);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(7, 8);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(7, 9);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(8, 7);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(8, 8);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(8, 9);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(9, 7);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(9, 8);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;
                                _sudoku2.fSet2(9, 9);
                                nReturn = _sudoku2.fGet();
                                nTotal += nReturn;

                            }
                        }
                    }
                }
            }
            MessageBox.Show(Convert.ToString(nTotal), "Box");
        
        } 

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
