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

            var birb = new Bird();
            birb.Color = "Red and Green";
            birb.NumberOFLimbs = 4;

            animals.Add(goodboi);
            animals.Add(birb);

            var birds = new List<IBird>();
            var dogs = new List<IDog>();
            

            foreach ( var animal in animals)
            {
                Console.WriteLine("This animal is " + animal.Color);
                Console.WriteLine("This animal has " + animal.NumberOFLimbs + " limbs");

                if (animal is Dog dog)
                {
                    dogs.Add(dog);
                }
                else if (animal is Bird bird)
                {
                    birds.Add(bird);
                }
            }

            foreach (var doggo in dogs)
            {
                doggo.Eat();
                doggo.Rest();
                doggo.Move();
            }
            foreach (var bird in birds)
            {
                bird.Eat();
                bird.Rest();
                bird.Fly();
                bird.Move();
            }

        }
    }
}
