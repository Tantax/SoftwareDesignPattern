using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Observer
{
    class ConcreteObserver1 : IObserver
    {
        public void Response()
        {
            Console.WriteLine("具体观察者1作出反应！");
        }
    }
    
    class ConcreteObserver2 : IObserver
    {
        public void Response()
        {
            Console.WriteLine("具体观察者2作出反应！");
        }
    }
}
