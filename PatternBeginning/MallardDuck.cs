using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine($"Mallard Duck Fly");
        }

        public void Quack()
        {
            Console.WriteLine($"Mallard Duck Quack");
        }
    }
}