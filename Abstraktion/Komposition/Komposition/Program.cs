using Komposition.Abstracts;
using Komposition.Concretes;
using Komposition.Interface;
using System;
using System.Collections.Generic;

namespace Komposition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var goodboi = new Dog();
            goodboi.Color = "Grey";
            goodboi.NumberOFLimbs = 4;

            var bird = new Bird();
            bird.Color = "Red and Green";
            bird.NumberOFLimbs = 4;

            animals.Add(goodboi);
            animals.Add(bird);

            var fliers = new List<IFly>();
            var movers = new List<IMove>();
            var eaters = new List<IEat>();
            var resters = new List<IRest>();

            foreach ( var animal in animals)
            {
                Console.WriteLine("This animal is " + animal.Color);
                Console.WriteLine("This animal has " + animal.NumberOFLimbs + " limbs");

                if (animal is Dog dog)
                {
                    movers.Add(dog);
                    eaters.Add(dog);
                    resters.Add(dog);
                }
                else if (animal is Bird bird)
                {
                    movers.Add(bird);
                    eaters.Add(bird);
                    resters.Add(bird);
                    fliers.Add(bird);
                }
            }

            foreach (var flier in fliers)
            {

            }
        }
    }
}
