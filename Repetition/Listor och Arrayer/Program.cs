using System;

namespace Listor_och_Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 5 namn.");
            string[] names = new string[5];

            for (int i = 0; i < 5; i++)
            {
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("Du skrev in dessa namnen, fast i motsatt årdning:");

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
