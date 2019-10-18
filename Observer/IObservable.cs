using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    interface IObservable
    {
        void add(IObserver o);
        void remove(IObserver o);
        void notifyToObservers();
    }
}
