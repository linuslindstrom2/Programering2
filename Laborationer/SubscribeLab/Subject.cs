using System;
using System.Collections.Generic;
using System.Text;

namespace SubscribeLab
{
    class Subject : ISubject
    {
        List<Observer> subscribers= new List<Observer>();



        public void Add(Observer observer)
        {
            subscribers.Add(observer);
        }
        public void Remove(Observer observer)
        {
            subscribers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in subscribers)
            {
                observer.Update();
            }

        }
    }
}
