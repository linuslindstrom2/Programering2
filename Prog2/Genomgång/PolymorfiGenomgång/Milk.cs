﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorfiGenomgång
{
    class Milk : Product
    {
        private int _fatContent;

        public int FatContent
        {
            get { return _fatContent; }
            
            set { _fatContent = value; }
        }

    }
}
