using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Observer
{
    abstract class Subject
    {
        protected List<IObserver> observers = new List<IObserver>();
        //增加观察者方法
        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }
        //删除观察者方法
        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }
        public abstract void NotifyObserver(); //通知观察者方法
    }
}
