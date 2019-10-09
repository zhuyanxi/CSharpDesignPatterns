using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }

        public void Quack()
        {
            Console.WriteLine($"Rubber Duck Quack");
        }
    }
}