using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class CurrentConditionsDisplay : IMyObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject subject)
        {
            _weatherData = subject;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
        }
    }
}