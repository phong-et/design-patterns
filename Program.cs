using System;
using Design_Patterns.Observer;
using Design_Patterns.Proxy;
namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ================ Observer ============== !");
            WeatherStation ws = new WeatherStation();
            ws.add(new DesktopDisplay());
            ws.add(new MobileDisplay());
            ws.notifyToObservers();
            ws.Temp = "200";
            ws.notifyToObservers();

            Console.WriteLine(" ================ Proxy ============== !");
            RegilionProxy rP = new RegilionProxy(new Human(age: 14, hasMarried: true));
            rP.makeLove();
            LawProxy lP = new LawProxy(new Human(age: 16, hasMarried: false));
            lP.makeLove();
            Console.Read();
        }
    }
}