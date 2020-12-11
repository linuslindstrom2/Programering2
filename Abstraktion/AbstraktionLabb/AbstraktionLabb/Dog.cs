using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    abstract class Dog
    {
        public String Race { get; set; }

        public String Color { get; set; }

        public abstract void Sleep();

        public abstract void Eat();
    }
}
