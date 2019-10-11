using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData
    {
        public double GetTemperature()
        {
            return 0f;
        }

        public double GetHumidity()
        {
            return 0f;
        }

        public double GetPressure()
        {
            return 0f;
        }

        /// <summary>
        /// 一旦气象测量更新，此方法会被调用
        /// </summary>
        public void MeasurementsChanged()
        {
        }
    }
}