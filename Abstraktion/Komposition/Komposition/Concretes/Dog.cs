using Komposition.Abstracts;
using Komposition.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Komposition.Concretes
{
    class Dog : Animal, IMove, IEat, IRest
    {
        public void Eat()
        {
            Console.WriteLine("Good boi is omnomnoming!");
        }

        public void Move()
        {
            Console.WriteLine("Dog is leaping into action!");
        }

        public void Rest()
        {
            Console.WriteLine("Good boi is snoring!");
        }
    }
}
