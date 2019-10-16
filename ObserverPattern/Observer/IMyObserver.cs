using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者模式：观察者接口
    /// </summary>
    public interface IMyObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}