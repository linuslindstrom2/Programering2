using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Shark : Animal
    {
        public Shark()
        {
            NumberOfLimbs = 5;
        }

        public override void Breathe()
        {
            Console.WriteLine("Shark is sifting water for oxygen!");
        }

        public override void Eat()
        {
            Console.WriteLine("Shart is devouring smaller fish");
        }

        public override void Rest()
        {
            Console.WriteLine("Shark is put on autopilot.");
        }
        public void Swim()
        {
            Console.WriteLine("Shark is swimming!");
        }
    }
}
