using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    class WeatherStation : IObservable
    {
        string _name;
        string _id;
        string _temp;
        List<IObserver> observers = new List<IObserver>();
        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Temp { get => _temp; set => _temp = value; }

        public WeatherStation(string Id = "Default Id", string Name = "Weather Station Default", string Temp = "100°C")
        {
            this.Id = Id;
            this.Name = Name;
            this.Temp = Temp;
        }
        public void add(IObserver o)
        {
            observers.Add(o);
        }

        public void notifyToObservers()
        {
            foreach (IObserver o in observers)
            {
                o.update(this);
            }
        }

        public void remove(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
