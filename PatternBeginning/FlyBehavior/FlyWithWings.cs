using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine($"I fly with wings!");
        }
    }
}