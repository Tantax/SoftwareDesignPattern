using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.FactoryMethod
{
    public class ProductA : IProduct
    {
        public void Show()
        {
            Console.WriteLine("我是产品A");
        }
    }

    public class ProductB : IProduct
    {
        public void Show()
        {
            Console.WriteLine("我是产品B");
        }
    }
}
