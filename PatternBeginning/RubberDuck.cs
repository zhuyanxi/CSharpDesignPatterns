﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackSqueak();
        }

        public override void Display()
        {
            Console.WriteLine($"Display a rubber duck.");
        }
    }
}