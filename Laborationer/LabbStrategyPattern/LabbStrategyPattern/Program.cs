using System;

namespace LabbStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What car do you want to buy?");
                Console.WriteLine("(1) - Lexus");
                Console.WriteLine("(2) - Tesla");
                Console.WriteLine("(3) - Audi");
                Console.WriteLine("(4) - Porsche");

                int choice = Convert.ToInt32(Console.ReadLine());
                
                String colourOfCar;
                String colourRims;

                switch (choice)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
