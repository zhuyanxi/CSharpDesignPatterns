using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    /// <summary>
    /// 观察者模式：观察者接口
    /// </summary>
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}