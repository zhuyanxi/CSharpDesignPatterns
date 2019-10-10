using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning.FlyBehavior
{
    public class FlyWithRocket : IFly
    {
        public void Fly()
        {
            Console.WriteLine($"I am flying with a rocket!");
        }
    }
}