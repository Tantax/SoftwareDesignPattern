using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.AbstractFactory
{
    public class AbstractFactory1 : IFactory
    {
        public IProduct1 GetProduct1()
        {
            Console.WriteLine("工厂1创建产品1");
            return new Product1();
        }

        public IProduct2 GetProduct2()
        {
            Console.WriteLine("工厂1创建产品2");
            return new Product2();
        }
    }

    public class AbstractFactory2 : IFactory
    {
        public IProduct1 GetProduct1()
        {
            Console.WriteLine("工厂2创建产品1");
            return new Product1();
        }

        public IProduct2 GetProduct2()
        {
            Console.WriteLine("工厂2创建产品2");
            return new Product2();
        }
    }
}
