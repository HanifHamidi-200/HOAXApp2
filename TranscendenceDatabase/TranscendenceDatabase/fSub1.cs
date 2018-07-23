﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranscendenceDatabase
{
    public partial class fSub1 : Form
    {
        private cTypical _data = new cTypical();
        private int mnCount;
        private List<String> _colname = new List<string> { "hCOLUMN", "nID", "sText", "sDescription" };
        private int mnItem;

        private void fReset()
        {
            mnCount = 0;
            mnItem = 0;

            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String sText=null;

            mnCount += 1;
            _data.fSet2(mnCount, txt1.Text, txt2.Text, txt3.Text, txt4.Text);

            for (int i = 1; i <= 4; i++)
            {
                sText = sText + _colname[i - 1] + "=" + _data.fGetCol(i - 1) + ", ";
            }
            lst1.Items.Add(sText);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lst1.SelectedIndex + 1;
        }

        private void btnInspect_Click(object sender, EventArgs e)
        {
            String sText=null;

            if (lst1.Items.Count > mnItem)
            {
                if (mnItem != 0)
                {


                    _data.fSet(mnItem);
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sText + _colname[i - 1] + "=" + _data.fGetCol(i - 1) + ", ";
                    }
                    MessageBox.Show(sText, "Inspect");
                }
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lst1.Items.RemoveAt(mnCount - 1);
            mnCount -= 1;

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            mnCount = 0;
            lst1.Items.Clear();
        }
    }
}
