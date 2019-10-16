using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 观察者模式：主题接口
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IMyObserver observer);

        void RemoveObserver(IMyObserver observer);

        void NotifyObserver();
    }
}