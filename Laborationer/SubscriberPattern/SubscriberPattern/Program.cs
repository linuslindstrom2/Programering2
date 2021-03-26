using System;

namespace SubscriberPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer observer1 = new Observer("Observer 1");
            subject.BecomeMember(observer1);

            Observer observer2 = new Observer("Observer 2");
            subject.BecomeMember(observer2);

            subject.Inventory++;

            Observer observer3 = new Observer("Observer 3");
            subject.BecomeMember(observer3);

            subject.Inventory++;

            Console.ReadLine();

            int Cont = 1;
            do
            {
                Console.WriteLine("what do you want to do?");
                Console.WriteLine("(1) - Add new member");
                Console.WriteLine("(2) - Remove a member"); 
                Console.WriteLine("(3) - Add new product to the store");




            } while (Cont == 1);
        }
    }
}
