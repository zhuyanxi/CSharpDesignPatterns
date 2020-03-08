using System;
namespace DecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double Cost()
        {
            return 1.89;
        }
    }
}
