    using System;

namespace HelloNiklas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

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

            if (alive == "yes")
            {
                Console.WriteLine("Happy to hear man.");
            }
            else if (alive == "no")
            {
                Console.WriteLine("Damn, sorry man...");
            }
        }
    }
}