using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Flyweight
{
    class UnsharedConcreteFlyweight
    {
        private string info;
        public UnsharedConcreteFlyweight(string info)
        {
            this.info = info;
        }
        public string GetInfo()
        {
            return info;
        }
        public void SetInfo(string info)
        {
            this.info = info;
        }
    }
}
