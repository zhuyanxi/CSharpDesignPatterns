using System;
namespace DecoratorPattern.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 2.59;
        }
    }
}
