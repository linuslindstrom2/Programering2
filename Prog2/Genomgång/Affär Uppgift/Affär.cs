using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Affär_Uppgift
{
    class Affär
    {
        

        private static List<Kund> _kund = new List<Kund>();

        static void Main(string[] args)
        {
            Console.WriteLine("hej");
            Console.WriteLine("Välkommen!");

            int betalt =0;
            do
            {
                Console.WriteLine(" (1) - Skapa kund");
                Console.WriteLine(" (2) - Köp varor");
                Console.WriteLine(" (3) - Betala");

                int menyval = TryGetNumber();
                Console.Clear();
                int kundval;

                switch (menyval)
                {
                    case 1:
                        CreateCustomer();
                        break;

                    case 2:
                        NoCustomer();

                        int o = 0;
                        kundval = 1;

                        Console.WriteLine("Vem ska köpa?");
                        for (int i = 0; i < _kund.Count; i++)
                        {
                            o = i + 1;
                            Console.WriteLine(" (" + o + ") - " + _kund[i]._name);
                        }
                        
                        do
                        {
                            kundval = TryGetNumber();
                        } while (kundval <= _kund.Count);
                        
                        Console.Clear(); 

                        int cont = 1;

                        Buy(kundval, cont);
                        break;

                    case 3:
                        NoCustomer();

                        int sum;
                        int totsum = 0; 
                        
                        for (int j = 0; j < _kund.Count; j++)
                        {

                            Console.WriteLine(_kund[j]._name + " har köpt:");
                            sum = 0;
                            for (int i = 0; i < _kund[j].kundvagn.Count; i++)
                            {
                                Console.WriteLine(" " +_kund[j].kundvagn[i]._name + " - " + _kund[j].kundvagn[i]._price + "kr");
                                sum += _kund[j].kundvagn[i]._price;
                            }

                            Console.WriteLine(" Totalt - " + sum + "kr");
                            Console.WriteLine();
                            totsum += sum;
                        }

                        Console.WriteLine("Totalt blir det " + totsum + "kr");
                        Console.WriteLine();
                        Console.WriteLine("Vill de betala?");
                        Console.WriteLine(" (1) - Ja"); 
                        Console.WriteLine(" (2) - nej");
                        int betala = TryGetNumber();
                        Console.Clear();
                       
                        switch (betala)
                        {
                            case 1:
                                betalt = 1;
                                break;

                            case 2:
                                betalt = 0;
                                break;
                        }
                        break;
                }
            } while (betalt!=1);
        }
        static void CreateCustomer()
        {
            Console.WriteLine("Vad heter kunden?");
            string name = Console.ReadLine();
            Console.Clear();
            _kund.Add(new Kund(name));
        }  
        static void NoCustomer()
        {
            if (_kund.Count == 0)
            {
                Console.WriteLine("Du har inga möjliga kunder");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                
            }
        }
        
        static void Buy(int kundval, int cont)
        {
            kundval -= 1;
            do
            {
                Console.WriteLine("Vad vill " + _kund[kundval]._name + " köpa?");
                Console.WriteLine(" (1) - Kaffe 25kr");
                Console.WriteLine(" (2) - Läsk 15kr");
                Console.WriteLine(" (3) - Saft 10kr");
                Console.WriteLine(" (4) - Macka 35kr");



                int val = TryGetNumber();

                int price;
                string name = "A";
                int antal;
                switch (val)
                {
                    case 1:
                        name = "Kaffe";
                        price = 25;
                        Console.WriteLine("Hur många?");

                        antal = TryGetNumber();

                        for (int i = 0; i < antal; i++)
                        {
                            _kund[kundval].kundvagn.Add(new Kaffe(name, price));
                        }
                        break;

                    case 2:
                        name = "Läsk";
                        price = 15;

                        Console.WriteLine("Hur många?");

                        antal = TryGetNumber();

                        for (int i = 0; i < antal; i++)
                        {
                            _kund[kundval].kundvagn.Add(new Läsk(name, price));
                        }
                        break;

                    case 3:
                        name = "Saft";
                        price = 10;

                        Console.WriteLine("Hur många?");

                        antal = TryGetNumber();

                        for (int i = 0; i < antal; i++)
                        {
                            _kund[kundval].kundvagn.Add(new Saft(name, price));
                        }
                        break;

                    case 4:
                        name = "Macka";
                        price = 35;

                        Console.WriteLine("Hur många?");

                        antal = TryGetNumber();

                        for (int i = 0; i < antal; i++)
                        {
                            _kund[kundval].kundvagn.Add(new Macka(name, price));
                        }
                        break;
                }
                Console.Clear();

                Console.WriteLine("Vill du köpa mer kundvagn?");
                Console.WriteLine(" (1) - Ja");
                Console.WriteLine(" (2) - Nej");

                cont = TryGetNumber();
                Console.Clear();
            } while (cont == 1);
        }

        private static int TryGetNumber()
        {
            int output;
            while (true)
            {
                try
                {
                    output = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Skriv en giltig siffra tack.");
                }
            }
            return output;
        }
      

    }
}