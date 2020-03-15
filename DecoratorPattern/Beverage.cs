namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string description = "Unknow Beverage";

        //public string GetDescription()
        //{
        //    return description;
        //}

        public abstract string GetDescription();

        public abstract double Cost();
    }
}
