using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //lägger till p och q och räknar ut n
            Console.WriteLine("Skriv in två valfria primtal");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int n = p * q;
            int g = n;
            Console.WriteLine("n är: " + n);

            // räknar ut t, alltså phi
            int t = (p - 1) * (q - 1);
            Console.WriteLine("t är: " + t);

            //skapar lista och lägger till alla tal mellan 0 och n
            List<int> parts = new List<int>();
            for(int i = 1; i <= n; i++)
            {
                parts.Add(i);
            }

            //tar bort alla som har common factor med p
            for(int i=1 ; i<=q ; i++)
            {
                if (p*i<=n)
                {
                    parts.Remove(p*i);
                    g -= 1;
                }
            }

            //tar bort alla som har common factor med q
            for (int i = 1; i <= p; i++)
            {
                if (q * i <= n)
                {
                    parts.Remove(q * i);
                    g -= 1;
                }
            }

            //tar bort första indexet som är 1
            parts.Remove(1);
            g -= 1;

            //skapar ny lista
            List<int> nummer = new List<int>();

            //lägger in alla tal som inte har common factor med p eller q
            for (int i = 0; i <= g ; i++)
            {
                if(parts[i] < t)
                {
                    nummer.Add(parts[i]);
                }
            }

            //skriver ut talen som finns i den nya listan
            Console.WriteLine("");
            Console.WriteLine("Talen som återstår är:");

            for (int i = 0; i < nummer.Count; i++)
            {
                Console.Write(nummer[i] + " ");
            }

            //Tar bort common factor med t, alltså phi av n
            for (int i = 0; i < nummer.Count; i++) 
            {
                if (t % nummer[i] == 0)
                {
                    nummer.Remove(nummer[i]);
                }
            }

            //Skriver ut talet e 
            Console.WriteLine("");
            Console.WriteLine("Talet e är: "+nummer[0]);
            int e = nummer[0];
            
            //Du skriver in nyckelns första siffra
            Console.WriteLine("Vad är nyckelns försata tal?");
            int key1 = Convert.ToInt32(Console.ReadLine());
            int key2 = n;
            Console.WriteLine("Din nyckel är: (" + key1 + "," + key2 +").");

            //Loop tills d gör att ekvationen = 1
            double d = 1 ;
            while ((d*e)%t != 1)
            {
                d += 1;
            }
            d -= 1;

            //skriver ut d
            Console.WriteLine("Talet d är " + d);
        }
    }
}