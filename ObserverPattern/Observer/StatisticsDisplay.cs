using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        public void Update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}