using System;
namespace DecoratorPattern.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99f;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
