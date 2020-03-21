using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern
{
    public class ProductA : BaseProduct
    {
        protected override void Show()
        {
            Console.WriteLine("我是产品A");
        }
    }

    public class ProductB : BaseProduct
    {
        protected override void Show()
        {
            Console.WriteLine("我是产品B");
        }
    }
}
