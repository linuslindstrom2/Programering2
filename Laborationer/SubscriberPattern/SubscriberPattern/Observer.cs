using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriberPattern
{
    class Observer : IObserver
    {
        public string ObserverName { get; private set; }

        public Observer(string name)
        {
            ObserverName = name;
        }

        public void Update()
        {
            Console.WriteLine(ObserverName + ": A new product has arrived at the store");
        }

    }
}
