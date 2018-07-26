using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIME
{
    public partial class fSub3 : Form
    {

        private List<int> _count = new List<int> { 63, 128, 18 };
        private List<String> _data1 = new List<String> { "health", "parole", "paper", "door", "station", "car", "book", "wings", "folder", "shop", "cat", "sheep", "goal", "target", "machine", "robot", "equipment", "joint", "apparatus", "window", "forest", "tree", "wood", "firm", "zoo", "paper", "story", "leaves", "orange", "apple", "mug", "water", "oil", "fish", "chicken", "dosage", "hill", "mountain", "prayerplace", "wall", "tape", "street", "parkway", "hoover", "pen", "brush", "scales", "notepad", "calendar", "diary", "monitor", "TV", "bicycle", "person", "desk", "utiliser", "bucket", "sand", "stone", "clouds", "star", "night", "message" };
        private List<String> _data2 = new List<String> { "to benefit", "to upgrade", "to climb", "to defer", "to count", "to build", "to track", "to unite", "to embellish", "to clean", "to come", "to arrive", "to read", "to write", "to notedown", "to typeup", "to scroll", "to search", "to separate", "to lightup", "to standup", "to fall", "to drop", "to smashup", "to throw", "to throwup", "to assemble", "to calculate", "to startagain", "to finish", "to leave", "to use", "to have", "to become", "to extend", "to shorten", "to walk", "to run", "to tighten", "to letgo", "to fillup", "to design", "to paint", "to arrange", "to wireup", "to smother", "to swap", "to takeapart", "to yodle", "to scribe", "to rearrange", "to mark", "to share", "to contact", "to delete", "to add", "to columnate", "to categorise", "to bless", "to drink", "to eat", "to receive", "to send", "to drawout", "to lookat", "to lineup", "to switchon", "to switchoff", "to grouptogether", "to call", "to shout", "to chase", "to fetch", "to drive", "to tinker", "to concieve", "to threaten", "to reply", "to warn", "to invite", "to augment", "to hideaway", "to buy", "to unwrap", "to triangulate", "to scratch", "to etch", "to duplicate", "to patternout", "to thread", "to sew", "to laceup", "to hangup", "to putdown", "to letloose", "to rest", "to replace", "to digup", "to digalong", "to verbalise", "to raceahead", "to explore", "to communicate", "to talk", "to set", "to tick", "to erase", "to colour", "to heatup", "to cooldown", "to thrustup", "to fish", "to plant", "to cement", "to shoot", "to herd", "to breed", "to flock", "to transpire", "to comein", "to goout", "to research", "to prove", "to relagate", "to ascend", "to monitor", "to appoint", "to datemark" };
        private List<String> _data3 = new List<String> { "my", "it", "their", "they", "so", "also", "too", "then", "be", "inspiteof", "nevertheless", "astosoandso", "behind", "infrontof", "further", "nearer", "under", "over" };
        private List<String> _usage = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null };
        private int nNumber;

        private void fQNext()
        {
            Random rnd1 = new Random();
            int nCount,nLength,nMode,nPos;
          
            for (int i = 1; i <= 12; i++)
            {
                _usage[i - 1] = "<NULLGATE>";
            }

            nLength = rnd1.Next(4, 13);
            for (int i = 1; i <= nLength; i++)
            {
                nNumber = rnd1.Next(1, 10);
               if (nNumber <= 3)
                {
                    nMode = 1;
                }
                else
                {
                    if (nNumber <= 6)
                    {
                        nMode = 2;
                    }
                    else
                    {
                        nMode = 3;
                    }
                }
                nCount = _count[nMode - 1];
                nPos = rnd1.Next(1, nCount + 1);
                switch (nMode)
                {
                    case 1:
                        _usage[i-1] = _data1[nPos - 1];
                        break;
                    case 2:
                        _usage[i - 1] = _data2[nPos - 1];
                        break;
                    default:
                        _usage[i - 1] = _data3[nPos - 1];
                        break;
                }
            }
            fUpdateDisplay();
           }

        private void fUpdateDisplay()
        {
            lbl1.Text = _usage[0];
            lbl2.Text = _usage[1];
            lbl3.Text = _usage[2];
            lbl4.Text = _usage[3];
            lbl5.Text = _usage[4];
            lbl6.Text = _usage[5];
            lbl7.Text = _usage[6];
            lbl8.Text = _usage[7];
            lbl9.Text = _usage[8];
            lbla.Text = _usage[9];
            lblb.Text = _usage[10];
            lblc.Text = _usage[11];
        }
        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fQNext();
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            fQNext();
        }
    }
}
