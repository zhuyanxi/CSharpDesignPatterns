using System;
using NUnit.Framework;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string description = "Unknow Beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();


        [Test]
        public void TestOne()
        {
            int i = 1;
            Assert.AreEqual(i, 1);
        }
    }
}
