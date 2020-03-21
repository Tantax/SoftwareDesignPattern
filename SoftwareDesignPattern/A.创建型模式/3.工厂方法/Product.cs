using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern
{
    public class ProductA : BaseProduct
    {
        public override void Show()
        {
            Console.WriteLine("我是产品A");
        }
    }

    public class ProductB : BaseProduct
    {
        public override void Show()
        {
            Console.WriteLine("我是产品B");
        }
    }
}
