using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Observer
{
    class ConcreteSubject : Subject
    {
        public override void NotifyObserver()
        {
            Console.WriteLine("具体目标发生改变...");
            Console.WriteLine("--------------");

            foreach (Object obs in observers)
            {
                ((IObserver)obs).Response();
            }
        }
    }
}
