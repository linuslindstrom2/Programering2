using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriberPattern
{
    interface ISubject
    {
        void BecomeMember(Observer observer);
        void RemoveMember(Observer observer);
        void Notify();

    }
}
