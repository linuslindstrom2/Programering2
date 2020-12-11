using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Tax : Dog
    {
        public Tax()
        {
            Race = "tax";
        }

        public override void Eat()
        {
            Console.WriteLine("Omnomnom. Eating from a small bowl!");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZzzZZzZz. Sleeping in a small basket!");
        }
    }
}
