    using System;
using System.Drawing;
using System.Linq.Expressions;

namespace HelloNiklas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello Niklas!");

            Gender();

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("Hello " + name + ", how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            string alive;

            if (age > 20)
            {
                Console.WriteLine("Dam, you're old...");
                Console.WriteLine("You sure you're alive?");
                alive = Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Nice, you're quite young!");
                Console.WriteLine("Then you're still alive?");
                alive = Console.ReadLine();
            }

            if (alive == "yes" || alive == "Yes")
            {
                Console.WriteLine("Happy to hear.");
            }
            else if (alive == "no" || alive == "No")
            {
                Console.WriteLine("Damn, sorry...");
            }
        }

        static void Gender()
        {
            Console.WriteLine("Are you a boy or girl?");

            var gender = Console.ReadLine();

            switch (gender)
            {
                case "boy":
                    Console.WriteLine("Hey boy");

                    break;
                case "Boy":
                    Console.WriteLine("Hey boy");

                    break;
                case "girl":
                    Console.WriteLine("Hey girl");

                    break;
                case "Girl":
                    Console.WriteLine("Hey girl");

                    break;
                default:

                    break;
            }
        }

        
    }
} 