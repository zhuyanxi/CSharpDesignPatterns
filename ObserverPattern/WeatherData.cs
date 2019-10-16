using ObserverPattern.Observer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData : ISubject//, IObservable<int>
    {
        private List<IMyObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IMyObserver>();
        }

        /// <summary>
        /// 获取温度
        /// </summary>
        /// <returns></returns>
        public double GetTemperature()
        {
            return _temperature;
        }

        /// <summary>
        /// 获取湿度
        /// </summary>
        /// <returns></returns>
        public double GetHumidity()
        {
            return _humidity;
        }

        /// <summary>
        /// 获取气压
        /// </summary>
        /// <returns></returns>
        public double GetPressure()
        {
            return _pressure;
        }

        /// <summary>
        /// 一旦气象测量更新，此方法会被调用
        /// </summary>
        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        /// <summary>
        /// 注册观察者
        /// </summary>
        /// <param name="observer"></param>
        public void RegisterObserver(IMyObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IMyObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        /// <summary>
        /// 通知观察者更新数据
        /// </summary>
        public void NotifyObserver()
        {
            foreach (var ob in _observers)
            {
                ob.Update(_temperature, _humidity, _pressure);
            }
        }
    }
}