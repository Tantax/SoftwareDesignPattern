using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Flyweight
{
    class FlyweightFactory
    {
        private readonly Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();
        public IFlyweight GetFlyweight(string key)
        {
            IFlyweight flyweight;
            flyweights.TryGetValue(key, out flyweight);
            if (flyweight != null)
            {
                Console.WriteLine("具体享元" + key + "已经存在，被成功获取！");
            }
            else
            {
                flyweight = new ConcreteFlyweight(key);
                flyweights.Add(key, flyweight);
            }
            return flyweight;
        }
    }
}
