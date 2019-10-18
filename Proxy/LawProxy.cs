using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy
{
    class LawProxy:IMakingLoveable
    {
        Human human;
        public LawProxy(Human h)
        {
            this.human = h;
        }
        public void makeLove()
        {
            if(human.Age >= 16)
            {
                Console.WriteLine("You're 16 year old. You can...");
                human.makeLove();
            }
        }
    }
}
