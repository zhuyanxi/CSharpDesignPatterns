﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class QuackNormal : IQuack
    {
        public void Quack()
        {
            Console.WriteLine($"Quack");
        }
    }
}