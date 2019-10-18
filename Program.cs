using System;
using Design_Patterns.Observer;
namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ Observer ============== !");
            WeatherStation ws = new WeatherStation();
            ws.add(new DesktopDisplay());
            ws.add(new MobileDisplay());
            ws.notifyToObservers();
            Console.Read();
        }
    }
}