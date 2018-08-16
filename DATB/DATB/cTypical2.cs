﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATB
{
    class cTypical2
    {
        private List<String> _col1 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null, null, null, null, null, null, null };
         private int mnRecord;

        public void fSet(int nRecord)
        {
            mnRecord = nRecord;
        }
        public void fSet2(int nRecord, String s1, String s2)
        {
            mnRecord = nRecord;
            _col1[mnRecord - 1] = s1;
            _col2[mnRecord - 1] = s2;
          }

        public int fGet()
        {
            return mnRecord;
        }

        public String fGetCol(int nCol)
        {
            switch (nCol)
            {
                case 1:
                    return _col1[mnRecord - 1];
                default:
                    return _col2[mnRecord - 1];
            }

        }
    }
}
