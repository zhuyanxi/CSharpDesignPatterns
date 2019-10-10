using System;

namespace PatternBeginning
{
    public abstract class Duck
    {
        public IFly flyBehavior;
        public IQuack quackBehavior;

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void SetFlyBehavior(IFly fly)
        {
            flyBehavior = fly;
        }

        public void SetQuackBehavior(IQuack quack)
        {
            quackBehavior = quack;
        }

        public void Swim()
        {
            Console.WriteLine($"All ducks float on the water");
        }

        public abstract void Display();
    }
}