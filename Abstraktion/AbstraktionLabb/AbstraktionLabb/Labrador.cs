using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Labrador : Dog
    {
        public Labrador()
        {
            Race = "labrador";
        }

        public override void Eat()
        {
            Console.WriteLine("Omnomnom. Eating from a large bowl!");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZzzZZzZz. Sleeping in a large basket!");
        }
    }
}
