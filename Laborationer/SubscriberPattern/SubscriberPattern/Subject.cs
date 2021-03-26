using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriberPattern
{
    class Subject : ISubject
    {
        private List<Observer> observers = new List<Observer>();
        private int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void BecomeMember(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveMember(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
