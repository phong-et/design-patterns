using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    interface IObserver
    {
        void update(IObservable o);
    }
}
