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
            Console.WriteLine("Välkommen!");

            int betalt =0;
            do
            {


                Console.WriteLine("(1) - Skapa kund");
                Console.WriteLine("(2) - Köp varor");
                Console.WriteLine("(3) - Betala");

                int menyval = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menyval)
                {
                    case 1:
                        CreateCustomer();
                        break;

                    case 2:
                        if (_kund.Count == 0)
                        {
                            Console.WriteLine("Du har inga möjliga kunder");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;
                        }
                        int kundval;
                        int o;
                        Console.WriteLine("Vem ska köpa?");
                        for (int i = 0; i < _kund.Count; i++)
                        {
                           o = i + 1;
                            Console.WriteLine("(" + o + ") - " + _kund[i]._name);
                        }
                        kundval = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        
                        kundval -= 1;
                        int cont = 1;

                        do
                        {
                            Console.WriteLine("Vad vill " + _kund[kundval]._name + " köpa?");
                            Console.WriteLine("(1) - Kaffe 25kr");
                            Console.WriteLine("(2) - Läsk 15kr");
                            Console.WriteLine("(3) - Saft 10kr");
                            Console.WriteLine("(4) - Macka 35kr");

                            int val = Convert.ToInt32(Console.ReadLine());

                            int price;
                            string name;
                            switch (val)
                            {
                                case 1:
                                    name = "Kaffe";
                                    price = 25;

                                    _kund[kundval].produkter.Add(new Product(name, price));
                                    break;

                                case 2:
                                    name = "Läsk";
                                    price = 15;

                                    _kund[kundval].produkter.Add(new Product(name, price));
                                    break;

                                case 3:
                                    name = "Saft";
                                    price = 10;

                                    _kund[kundval].produkter.Add(new Product(name, price));
                                    break;

                                case 4:
                                    name = "Macka";
                                    price = 35;

                                    _kund[kundval].produkter.Add(new Product(name, price));
                                    break;

                                default:
                                    break;
                            }
                            Console.Clear();
                            Console.WriteLine("Vill du köpa mer produkter?");
                            Console.WriteLine("(1) - Ja");
                            Console.WriteLine("(2) - Nej");

                            cont = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        } while (cont == 1);
                        break;

                    case 3:
                        if (_kund.Count == 0)
                        {
                            Console.WriteLine("Du har inga möjliga kunder");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;
                        }

                        int sum;
                        int j = 0;
                        int totsum = 0;
                        for (j = 0; j < _kund.Count; j++)
                        {
                            sum = 0;
                            for (int i = 0; i < _kund[j].produkter.Count; i++)
                            {
                                sum += _kund[j].produkter[i]._price;
                            }

                            Console.WriteLine("summan för " + _kund[j]._name + " är " + sum);
                            totsum += sum;
                        }

                        Console.WriteLine("Totalt blir det " + totsum);
                        Console.WriteLine("Vill de betala?");
                        Console.WriteLine("(1) - Ja"); 
                        Console.WriteLine("(2) - nej");
                        int betala = Convert.ToInt32(Console.ReadLine());
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
    }
}