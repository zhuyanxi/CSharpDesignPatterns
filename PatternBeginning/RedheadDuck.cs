using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBeginning
{
    public class RedheadDuck : Duck
    {
        public override void Display()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine($"Redhead Duck Fly");
        }

        public void Quack()
        {
            Console.WriteLine($"Redhead Duck Quack");
        }
    }
}