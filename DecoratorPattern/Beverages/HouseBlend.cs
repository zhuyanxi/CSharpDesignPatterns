using System;
namespace DecoratorPattern.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
