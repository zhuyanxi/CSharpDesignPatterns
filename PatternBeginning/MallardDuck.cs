using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new QuackNormal();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine($"Display a real mallard duck.");
        }
    }
}