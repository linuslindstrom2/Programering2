using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorfiGenomgång
{
    class Coffe : Product
    {
        private String _roast;

        public String Roast
        {
            get { return _roast; }
            set { _roast = value; }
        }

    }
}
