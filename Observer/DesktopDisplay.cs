using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    public class DesktopDisplay :IObserver, IDisplay
    {
        public void display(string temp)
        {
            Console.WriteLine("Display Of Desktop Device: " + temp);
        }

        void IObserver.update(IObservable o)
        {
            Console.WriteLine("Desktop Device Updated : " + o.ToString());
            if (o.GetType() == typeof(WeatherStation))
                display(((WeatherStation)o).Temp);
        }
    }
}
