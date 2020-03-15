using System;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using NUnit.Framework;

namespace DecoratorPattern
{
    public class StarbuzzCoffeeTest
    {
        [Test]
        public void TestOrderEspressoWithNoCondiments()
        {
            Beverage beverage = new Espresso();
            string test = $"{beverage.GetDescription()} ${beverage.Cost().ToString("0.00")}";
            Assert.AreEqual(test, "Espresso $1.99");
        }

        [Test]
        public void TestOrderDarkRoastWithMochaWhip()
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            string test = $"{beverage.GetDescription()} ${beverage.Cost().ToString("0.00")}";
            Assert.AreEqual(test, "Dark Roast, Mocha, Mocha, Whip $2.54");
        }

        [Test]
        public void TestOrderHouseBlendWithSoyMochaWhip()
        {
            Beverage beverage = new HouseBlend();
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            string test = $"{beverage.GetDescription()} ${beverage.Cost().ToString("0.00")}";
            Assert.AreEqual(test, "House Blend Coffee, Soy, Mocha, Whip $1.49");
        }
    }
}
