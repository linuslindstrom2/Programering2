using System;
using System.Collections.Generic;

namespace PolymorfiGenomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> cart = new List<Product>();

            Milk milk = new Milk();
            milk.FatContent = 1;
            milk.ProcuctNumber = 123;
            milk.StockStatus = 10;
            cart.Add(milk);

            Monster monster = new Monster();
            monster.Flavour = "cola";
            monster.ProcuctNumber = 234;
            monster.StockStatus = 14;

            cart.Add(monster);
            
            Coffe coffe = new Coffe();
            coffe.Roast = "dark";
            coffe.ProcuctNumber = 234;
            coffe.StockStatus = 14;

            cart.Add(coffe);


        }
    }
}
