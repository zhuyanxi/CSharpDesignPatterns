using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class QuackSqueak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine($"Squeak");
        }
    }
}