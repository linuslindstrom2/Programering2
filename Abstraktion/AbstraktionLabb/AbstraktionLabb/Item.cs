using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    abstract class Item
    {
        public String TypeOfContainer { get; set; }

        public String SortOfItem { get; set; }

        public abstract void Use();

        public abstract void SmellIt();
    }
}
