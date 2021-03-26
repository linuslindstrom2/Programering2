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
        }
    }
}
