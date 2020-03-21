using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern
{
    public abstract class BaseProduct
    {
        protected virtual void Show()
        {
            Console.WriteLine("我是抽象类");
        }
    }

}
