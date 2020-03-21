using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.AbstractFactory
{
    public class Product1 : IProduct1
    {
        public void Show()
        {
            Console.WriteLine("我是产品1");
        }
    }

    public class Product2 : IProduct2
    {
        public void Show()
        {
            Console.WriteLine("我是产品2");
        }
    }
}
