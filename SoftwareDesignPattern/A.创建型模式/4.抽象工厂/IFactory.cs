using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.AbstractFactory
{
    public interface IFactory
    {
        IProduct1 GetProduct1();
        IProduct2 GetProduct2();
    }
}
