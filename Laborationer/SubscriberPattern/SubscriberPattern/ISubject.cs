using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriberPattern
{
    interface ISubject
    {
        public void BecomeMember(Observer observer);
        public void RemoveMember(Observer observer);
        public void Notify();

    }
}
