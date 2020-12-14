using Komposition.Abstracts;
using Komposition.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Komposition.Concretes
{
    class Bird : Animal, IMove, IEat, IFly, IRest
    {
        public void Eat()
        {
            Console.WriteLine("Bird is devouring dem fruits!");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is soaring majestically!");
        }

        public void Move()
        {
            Console.WriteLine("Bird is skipping and hopping!");
        }

        public void Rest()
        {
            Console.WriteLine("Bird go sleep, bye bye!");
        }
    }
}
