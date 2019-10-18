using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy
{
    class Human : IMakingLoveable
    {
        int _age;

        public int Age { get => _age; set => _age = value; }
        public bool HasMarried { get => hasMarried; set => hasMarried = value; }

        private bool hasMarried;
        public Human(int age = 1, bool hasMarried = false)
        {
            this.Age = age;
            this.hasMarried = hasMarried;
        }
        public void makeLove()
        {
            Console.WriteLine("Make love with lover");
        }
    }
}
