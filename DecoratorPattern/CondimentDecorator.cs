using System;
namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract new string GetDescription();

        public override double Cost()
        {
            throw new NotImplementedException();
        }
    }
}
