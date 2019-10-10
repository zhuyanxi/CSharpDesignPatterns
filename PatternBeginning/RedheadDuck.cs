using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackNormal();
        }

        public override void Display()
        {
            Console.WriteLine($"Display a real redhead duck.");
        }
    }
}