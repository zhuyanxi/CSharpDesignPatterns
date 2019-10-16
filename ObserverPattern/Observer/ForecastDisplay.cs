using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class ForecastDisplay : IMyObserver, IDisplayElement
    {
        private ISubject _weatherData;

        public ForecastDisplay(ISubject subject)
        {
            _weatherData = subject;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}