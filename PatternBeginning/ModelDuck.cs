using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackMute();
        }

        public override void Display()
        {
            Console.WriteLine($"Display a model duck.");
        }
    }
}