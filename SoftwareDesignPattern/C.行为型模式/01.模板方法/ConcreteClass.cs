using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.TemplateMethod
{
    class ConcreteClass : AbstractClass
    {
        public override void AbstractMethod1()
        {
            Console.WriteLine("抽象方法1的实现被调用...");
        }

        public override void AbstractMethod2()
        {
            Console.WriteLine("抽象方法2的实现被调用...");
        }
    }
}
