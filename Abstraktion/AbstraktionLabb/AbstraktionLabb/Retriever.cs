using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktionLabb
{
    class Retriever : Dog
    {
        public Retriever()
        {
            Race = "retriever";
        }

        public override void Eat()
        {
            Console.WriteLine("Nomnom. Eating from a large bowl!");
        }

        public override void Sleep()
        {
            Console.WriteLine("zZzZzZz. Sleeping in a large basket!");
        }
    }
}
