using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Flyweight
{
    class ConcreteFlyweight : IFlyweight
    {
        private string Key { get; set; }
        public ConcreteFlyweight(string key)
        {
            this.Key = key;
        }
        public void Operation(UnsharedConcreteFlyweight outState)
        {
            Console.WriteLine(Key);
            outState.GetInfo();
        }
    }
}
