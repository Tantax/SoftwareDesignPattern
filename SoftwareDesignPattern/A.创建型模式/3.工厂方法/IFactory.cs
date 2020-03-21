using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.FactoryMethod
{
    public interface IFactory
    {
        IProduct GetProduct();
    }
}
