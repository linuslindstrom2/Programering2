using System;
using System.Collections.Generic;
using System.Text;

namespace Labb
{
    class Bird : Animal
    {
        public Bird(string color) : base(color)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Bird is peck-peck-pecking away!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Bird is sleeping!");
        }

        public override void Speak()
        {
            Console.WriteLine("Bird is chirping!");
        }
    }
}

