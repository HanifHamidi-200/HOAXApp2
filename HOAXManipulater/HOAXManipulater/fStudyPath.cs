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

namespace HOAXManipulater
{
    public partial class fStudyPath : Form
    {
        private int mnItem,mnRotate;

        public fStudyPath()
        {
            InitializeComponent();
        }

        private void lstChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lstChoose.SelectedIndex + 1;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnRotate = rnd1.Next(1, 5);
            btnRotate.Text = "Rotate = " + Convert.ToString(mnRotate);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String sText = null;

            String sName= "dlg.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                sText = Convert.ToString(mnItem);
                file.WriteLine(sText);
                sText = Convert.ToString(mnRotate);
                file.WriteLine(sText);
            }

        
         }

            private void fStudyPath_Load(object sender, EventArgs e)
        {
            mnItem = 1;
            mnRotate = 1;
            lstChoose.SelectedIndex = 0;
        }
    }
}
