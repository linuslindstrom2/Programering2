using System;

namespace _3MetoderUppgift
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5]; 
            Console.WriteLine("Skriv in 5 heltal.");
            for (int i = 0 ; i < 5 ; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Addition(numbers));

            string[] words = new string[5];
            Console.WriteLine("\n" + "Skriv in 5 ord.");
            for (int i = 0; i < 5; i++)
            {
                words[i] = Console.ReadLine();
            }            
            Console.WriteLine(OmvändaOrd(words));

            int[] numbersToCompare = new int[5];
            Console.WriteLine("Skriv in 5 olika nummer.");
            for (int i = 0; i < 5; i++)
            {
                numbersToCompare[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine(StörstaOchMinsta(numbersToCompare).Item1);
        }

        static int Addition(int[] nummer)
        {
            int sum=0;
            for (int i = 0; i < 5; i++)
            {
                sum += nummer[i];
            }
            return sum;
        }

        static String[] OmvändaOrd(String[]ord)
        {
            Console.WriteLine("Du skrev in dessa orden, fast i motsatt årdning:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(ord[i]);
            }
            return null;
        }

        static (int,int) StörstaOchMinsta(int[] numbersToCompare)
        {
            int biggest = 0;
            int smallest = numbersToCompare[0];
            for (int i = 0; i < numbersToCompare.Length; i++)
            {
                if (numbersToCompare[i] > biggest)
                {
                    biggest = numbersToCompare[i];
                }
                if (numbersToCompare[i] < smallest)
                {
                    smallest = numbersToCompare[i];
                }

            }
            return (biggest, smallest);

        }
    }
}
