using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.FactoryMethod
{
    public class FactoryMethodA : IFactory
    {
        public IProduct GetProduct()
        {
            return new ProductA();
        }
    }

    public class FactoryMethodB : IFactory
    {
        public IProduct GetProduct()
        {
            return new ProductB();
        }
    }
}
