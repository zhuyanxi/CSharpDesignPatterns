﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class FlyNoWay : IFly
    {
        public void Fly()
        {
            Console.WriteLine($"I can not fly.");
        }
    }
}