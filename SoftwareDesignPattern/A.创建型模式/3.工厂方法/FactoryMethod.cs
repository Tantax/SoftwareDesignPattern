using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern
{
    public class FactoryMethodA : IFactory
    {
        public BaseProduct GetProduct()
        {
            return new ProductA();
        }
    }

    public class FactoryMethodB : IFactory
    {
        public BaseProduct GetProduct()
        {
            return new ProductB();
        }
    }
}
