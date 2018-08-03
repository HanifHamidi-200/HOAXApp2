using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexEdit
{
    public partial class Form1 : Form
    {
        private int mnCompare1, mnCompare2;
        private  List<int> _top1= new List<int> { 72, 79, 65, 88, 72, 65, 86, 79, 67, 0 };
        private  List<int> _top2 = new List<int> { 82, 73, 77, 69, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top3 = new List<int> { 85, 80, 77, 79, 76, 0, 0, 0, 0, 0 };
        private  List<int> _top4 = new List<int> { 68, 65, 84, 66, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top5 = new List<int> { 82, 89, 68, 88, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top6 = new List<int> { 65, 74, 83, 84, 80, 0, 0, 0, 0, 0 };
        private  List<int> _top7 = new List<int> { 82, 77, 78, 68, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top8 = new List<int> { 83, 67, 75, 77, 84, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top9 = new List<int> { 72, 65, 73, 66, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top10 = new List<int> { 74, 71, 78, 86, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top11 = new List<int> { 83, 72, 83, 77, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top12 = new List<int> { 77, 69, 90, 69, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top13 = new List<int> { 71, 79, 76, 70, 0, 0, 0, 0, 0, 0 };
        private  List<int> _top14 = new List<int> { 67, 85, 82, 89, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom1 = new List<int> { 206, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom2 = new List<int> { 136, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom3 = new List<int> { 80, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom4 = new List<int> { 96, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom5 = new List<int> { 240, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom6 = new List<int> { 85, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom7 = new List<int> { 144, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom8 = new List<int> { 152, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom9 = new List<int> { 48, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom10 = new List<int> { 16, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom11 = new List<int> { 88, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom12 = new List<int> { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom13 = new List<int> { 40, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private  List<int> _bottom14 = new List<int> { 72, 0, 0, 0, 0, 0, 0, 0, 0, 0 };



        public Form1()
        {
            InitializeComponent();
           
        }

        private String fHex(int nNumber)
        {
            String sHex;
            int nTens, nUnits;

            sHex = null;
            nTens = 0;
            nUnits = 0;
            if (nNumber <= 15)
            {
                nUnits = nNumber;
            }
            else
            {
                do
                {
                    nNumber -= 16;
                    nTens += 1;
                } while (nNumber > 15);
                nUnits = nNumber;
            }
            switch (nTens)
            {
                case 10:
                    sHex = "a";
                    break;
                case 11:
                    sHex = "b";
                    break;
                case 12:
                    sHex = "c";
                    break;
                case 13:
                    sHex = "d";
                    break;
                case 14:
                    sHex = "e";
                    break;
                case 15:
                    sHex = "f";
                    break;
                case 0:
                    break;
                default:
                    sHex = Convert.ToString(nTens);
                    break;
            }
            switch (nUnits)
            {
                case 10:
                    sHex = sHex + "a";
                    break;
                case 11:
                    sHex = sHex + "b";
                    break;
                case 12:
                    sHex = sHex + "c";
                    break;
                case 13:
                    sHex = sHex + "d";
                    break;
                case 14:
                    sHex = sHex + "e";
                    break;
                case 15:
                    sHex = sHex + "f";
                    break;
                case 0:
                    sHex = sHex + "0";
                    break;
                default:
                    sHex = sHex + Convert.ToString(nUnits);
                    break;
            }

            return sHex;
        }
        private void fCompare2()
        {
            int nNumber;
            String sHex;

            for (int i = 1; i <= 10; i++)
            {
                switch (mnCompare2)
                {
                    case 1:
                        nNumber = _top1[i - 1];
                        break;
                    case 2:
                        nNumber = _top2[i - 1];
                        break;
                    case 3:
                        nNumber = _top3[i - 1];
                        break;
                    case 4:
                        nNumber = _top4[i - 1];
                        break;
                    case 5:
                        nNumber = _top5[i - 1];
                        break;
                    case 6:
                        nNumber = _top6[i - 1];
                        break;
                    case 7:
                        nNumber = _top7[i - 1];
                        break;
                    case 8:
                        nNumber = _top8[i - 1];
                        break;
                    case 9:
                        nNumber = _top9[i - 1];
                        break;
                    case 10:
                        nNumber = _top10[i - 1];
                        break;
                    case 11:
                        nNumber = _top11[i - 1];
                        break;
                    case 12:
                        nNumber = _top12[i - 1];
                        break;
                    case 13:
                        nNumber = _top13[i - 1];
                        break;
                    default:
                        nNumber = _top14[i - 1];
                        break;
                }
                sHex = fHex(nNumber);
                switch (i)
                {
                    case 1:
                        txt2_1.Text = sHex;
                        break;
                    case 2:
                        txt2_2.Text = sHex;
                        break;
                    case 3:
                        txt2_3.Text = sHex;
                        break;
                    case 4:
                        txt2_4.Text = sHex;
                        break;
                    case 5:
                        txt2_5.Text = sHex;
                        break;
                    case 6:
                        txt2_6.Text = sHex;
                        break;
                    case 7:
                        txt2_7.Text = sHex;
                        break;
                    case 8:
                        txt2_8.Text = sHex;
                        break;
                    case 9:
                        txt2_9.Text = sHex;
                        break;
                    default:
                        txt2_10.Text = sHex;
                        break;
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                switch (mnCompare2)
                {
                    case 1:
                        nNumber = _bottom1[i - 1];
                        break;
                    case 2:
                        nNumber = _bottom2[i - 1];
                        break;
                    case 3:
                        nNumber = _bottom3[i - 1];
                        break;
                    case 4:
                        nNumber = _bottom4[i - 1];
                        break;
                    case 5:
                        nNumber = _bottom5[i - 1];
                        break;
                    case 6:
                        nNumber = _bottom6[i - 1];
                        break;
                    case 7:
                        nNumber = _bottom7[i - 1];
                        break;
                    case 8:
                        nNumber = _bottom8[i - 1];
                        break;
                    case 9:
                        nNumber = _bottom9[i - 1];
                        break;
                    case 10:
                        nNumber = _bottom10[i - 1];
                        break;
                    case 11:
                        nNumber = _bottom11[i - 1];
                        break;
                    case 12:
                        nNumber = _bottom12[i - 1];
                        break;
                    case 13:
                        nNumber = _bottom13[i - 1];
                        break;
                    default:
                        nNumber = _bottom14[i - 1];
                        break;
                }
                sHex = fHex(nNumber);
                switch (i)
                {
                    case 1:
                        txt2_11.Text = sHex;
                        break;
                    case 2:
                        txt2_12.Text = sHex;
                        break;
                    case 3:
                        txt2_13.Text = sHex;
                        break;
                    case 4:
                        txt2_14.Text = sHex;
                        break;
                    case 5:
                        txt2_15.Text = sHex;
                        break;
                    case 6:
                        txt2_16.Text = sHex;
                        break;
                    case 7:
                        txt2_17.Text = sHex;
                        break;
                    case 8:
                        txt2_18.Text = sHex;
                        break;
                    case 9:
                        txt2_19.Text = sHex;
                        break;
                    default:
                        txt2_20.Text = sHex;
                        break;
                }
            }

        }


        private void fCompare1()
        {
            int nNumber;
            String sHex;

            for (int i = 1; i <= 10; i++)
            {
                switch (mnCompare1)
                {
                    case 1:
                        nNumber = _top1[i - 1];
                        break;
                    case 2:
                        nNumber = _top2[i - 1];
                        break;
                    case 3:
                        nNumber = _top3[i - 1];
                        break;
                    case 4:
                        nNumber = _top4[i - 1];
                        break;
                    case 5:
                        nNumber = _top5[i - 1];
                        break;
                    case 6:
                        nNumber = _top6[i - 1];
                        break;
                    case 7:
                        nNumber = _top7[i - 1];
                        break;
                    case 8:
                        nNumber = _top8[i - 1];
                        break;
                    case 9:
                        nNumber = _top9[i - 1];
                        break;
                    case 10:
                        nNumber = _top10[i - 1];
                        break;
                    case 11:
                        nNumber = _top11[i - 1];
                        break;
                    case 12:
                        nNumber = _top12[i - 1];
                        break;
                    case 13:
                        nNumber = _top13[i - 1];
                        break;
                    default:
                        nNumber = _top14[i - 1];
                        break;
                }
                sHex = fHex(nNumber);
                switch (i)
                {
                    case 1:
                        txt1_1.Text = sHex;
                        break;
                    case 2:
                        txt1_2.Text = sHex;
                        break;
                    case 3:
                        txt1_3.Text = sHex;
                        break;
                    case 4:
                        txt1_4.Text = sHex;
                        break;
                    case 5:
                        txt1_5.Text = sHex;
                        break;
                    case 6:
                        txt1_6.Text = sHex;
                        break;
                    case 7:
                        txt1_7.Text = sHex;
                        break;
                    case 8:
                        txt1_8.Text = sHex;
                        break;
                    case 9:
                        txt1_9.Text = sHex;
                        break;
                    default:
                        txt1_10.Text = sHex;
                        break;
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                switch (mnCompare1)
                {
                    case 1:
                        nNumber = _bottom1[i - 1];
                        break;
                    case 2:
                        nNumber = _bottom2[i - 1];
                        break;
                    case 3:
                        nNumber = _bottom3[i - 1];
                        break;
                    case 4:
                        nNumber = _bottom4[i - 1];
                        break;
                    case 5:
                        nNumber = _bottom5[i - 1];
                        break;
                    case 6:
                        nNumber = _bottom6[i - 1];
                        break;
                    case 7:
                        nNumber = _bottom7[i - 1];
                        break;
                    case 8:
                        nNumber = _bottom8[i - 1];
                        break;
                    case 9:
                        nNumber = _bottom9[i - 1];
                        break;
                    case 10:
                        nNumber = _bottom10[i - 1];
                        break;
                    case 11:
                        nNumber = _bottom11[i - 1];
                        break;
                    case 12:
                        nNumber = _bottom12[i - 1];
                        break;
                    case 13:
                        nNumber = _bottom13[i - 1];
                        break;
                    default:
                        nNumber = _bottom14[i - 1];
                        break;
                }
                sHex = fHex(nNumber);
                switch (i)
                {
                    case 1:
                        txt1_11.Text = sHex;
                        break;
                    case 2:
                        txt1_12.Text = sHex;
                        break;
                    case 3:
                        txt1_13.Text = sHex;
                        break;
                    case 4:
                        txt1_14.Text = sHex;
                        break;
                    case 5:
                        txt1_15.Text = sHex;
                        break;
                    case 6:
                        txt1_16.Text = sHex;
                        break;
                    case 7:
                        txt1_17.Text = sHex;
                        break;
                    case 8:
                        txt1_18.Text = sHex;
                        break;
                    case 9:
                        txt1_19.Text = sHex;
                        break;
                    default:
                        txt1_20.Text = sHex;
                        break;
                }
            }

        }

        private void btnNav11_Click(object sender, EventArgs e)
        {
            mnCompare1 -= 1;
            if (mnCompare1 == 0)
            {
                mnCompare1 = 14;
            }
            txtNav1.Text = Convert.ToString(mnCompare1);
            fCompare1();
        }

        private void btnNav12_Click(object sender, EventArgs e)
        {
            mnCompare1 += 1;
            if (mnCompare1 == 15)
            {
                mnCompare1 = 1;
            }
            txtNav1.Text = Convert.ToString(mnCompare1);
            fCompare1();

        }

        private void btnNav21_Click(object sender, EventArgs e)
        {
            mnCompare2 -= 1;
            if (mnCompare2 == 0)
            {
                mnCompare2 = 14;
            }
            txtNav2.Text = Convert.ToString(mnCompare2);
            fCompare2();

        }

        private void btnNav22_Click(object sender, EventArgs e)
        {
            mnCompare2 += 1;
            if (mnCompare2 == 15)
            {
                mnCompare2 = 1;
            }
            txtNav2.Text = Convert.ToString(mnCompare2);
            fCompare2();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
             String sText;
      

            for (int i = 65; i <= 65 + 26; i++)
            {
                sText = Convert.ToString(i) + " = " + (char)i;
                lst1.Items.Add(sText);
            }

            mnCompare1 = rnd1.Next(1, 15);
            mnCompare2 = rnd1.Next(1, 15);
            txtNav1.Text = Convert.ToString(mnCompare1);
            txtNav2.Text = Convert.ToString(mnCompare2);

            fCompare1();
            fCompare2();
        }
    }
}
