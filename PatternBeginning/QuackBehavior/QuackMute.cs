using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class QuackMute : IQuack
    {
        public void Quack()
        {
            Console.WriteLine($"I can not quack<<silence>>");
        }
    }
}