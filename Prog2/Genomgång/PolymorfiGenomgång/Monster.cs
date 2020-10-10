using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorfiGenomgång
{
    class Monster : Product
    {
        private String _flavour; 

        public  String Flavour
        {
            get { return _flavour; }
            set { _flavour = value; }
        }

    }
}
