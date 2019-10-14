using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        /// <summary>
        /// 获取温度
        /// </summary>
        /// <returns></returns>
        public double GetTemperature()
        {
            return 0f;
        }

        /// <summary>
        /// 获取湿度
        /// </summary>
        /// <returns></returns>
        public double GetHumidity()
        {
            return 0f;
        }

        /// <summary>
        /// 获取气压
        /// </summary>
        /// <returns></returns>
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

        public void RegisterObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObserver()
        {
            throw new NotImplementedException();
        }
    }
}