using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Affär_Uppgift
{
    class Affär
    {

        private static List<Kund> kunder = new List<Kund>();

        
        static void Main(string[] args)
        {





            Console.WriteLine("Welcome!");
            CreateCustomer();
            Console.WriteLine(kunder[0]._name);

        }

        static void CreateCustomer()
        {

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            kunder.Add(new Kund(name));


        }

        
    }
}