using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy
{
    class RegilionProxy : IMakingLoveable
    {
        Human human = new Human();
        public RegilionProxy(Human h)
        {
            this.human = h;
        }
        public void makeLove()
        {
            if (human.HasMarried)
            {
                Console.WriteLine("You've been married. You can...");
                human.makeLove();
            }
                
        }
    }
}
