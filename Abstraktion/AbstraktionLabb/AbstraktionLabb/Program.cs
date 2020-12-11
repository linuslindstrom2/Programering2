using System;
using System.Collections.Generic;

namespace AbstraktionLabb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> ReciepDog = new List<Dog>();
            List<Item> ReciepItem= new List<Item>();

            Console.WriteLine("Welcome!" + "\n" + "What type of dog do you want to buy?" + "\n" + "(1) - Retriever" + "\n" + "(2) - Labrador" + "\n" + "(3) - Tax");

            int WichDog = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("What color do you want your dog to be?");
            String WichColor = Console.ReadLine();

            if (WichDog == 1)
            {
                var YourDog = new Retriever();
                YourDog.Color = WichColor;
                ReciepDog.Add(YourDog);
            }
            else if (WichDog == 2)
            {
                var YourDog = new Labrador(); 
                YourDog.Color = WichColor;
                ReciepDog.Add(YourDog);
            }
            else if (WichDog == 3)
            {
                var YourDog = new Tax();
                YourDog.Color = WichColor;
                ReciepDog.Add(YourDog);
            }

            Console.WriteLine("Do you want to buy a:");


            for (int i = 0; i < ReciepDog.Count; i++)
            {
                Console.WriteLine(ReciepDog[i].Color + " " + ReciepDog[i].Race.ToLower());
            }







        }
    }
}
