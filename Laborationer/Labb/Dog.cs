﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labb
{
    class Dog : Animal , TransferOwnership
    {


        public Dog(string color) : base(color)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Dog is eating. " + _owner + " is happy!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog is sleeping!");
        }

        public override void Speak()
        {
            Console.WriteLine("Dog is barking!");
        }
    }

}

