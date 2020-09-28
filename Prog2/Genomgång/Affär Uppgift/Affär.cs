using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Affär_Uppgift
{
    class Affär
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {


                Console.WriteLine("Hej, välkommen till affären!");
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("(1) - Skapa kund");
                Console.WriteLine("(2) - Lägga varor i korg");
                Console.WriteLine("(3) - Betala");

                int val = Convert.ToInt32(Console.ReadLine());
                switch (val)
                {
                    case 1:

                        Console.WriteLine("Vad heter kunden?");
                        string name = Console.ReadLine();

                        Console.WriteLine("Hur gammal är kunden?");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Kund kund1 = new Kund(name, age);
                        break;

                    case 2:
                        Console.WriteLine("2");
                        break;

                    case 3:
                        Console.WriteLine("3");
                        break;

                    default:
                        break;
                }

            } while (cont == true);
        }
    }
}