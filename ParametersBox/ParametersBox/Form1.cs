using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParametersBox
{
    public partial class Form1 : Form
    {
        private int nNumber;
        private int mnLevels;

        private String fFormname()
        {
            Random rnd1 = new Random();
            String sCase = "abcde";
            String sText = null;
            int nSubtext = rnd1.Next(1, 20001);
       
            for (int i = 1; i <= 5; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sText = sText + sCase.Substring(i - 1);
                }
            }
            return sText+Convert.ToString(nSubtext);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String sName;

            mnLevels = 1;
            lst1.Nodes.Clear();
            for (int i = 1; i <= 5; i++)
            {
                sName = fFormname();
                lst1.Nodes.Add(sName);
            }
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            String sName;

            mnLevels = 1;
            lst1.Nodes.Clear();
            for (int i = 1; i <= 5; i++)
            {
                sName = fFormname();
                lst1.Nodes.Add(sName);
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCount;
        
            switch (mnLevels)
            {
                case 1:
                 
                    for (int i = 1; i <= 5; i++)
                    {
                        TreeNode docNode = new TreeNode(fFormname());
                        nCount = rnd1.Next(1, 5);
                        for (int j = 1; j <= nCount; j++)
                        {
                            docNode.Nodes.Add(fFormname());
                        }
                        lst1.Nodes.Add(docNode);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
