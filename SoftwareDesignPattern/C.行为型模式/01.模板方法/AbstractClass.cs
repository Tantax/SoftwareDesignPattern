using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.TemplateMethod
{
    abstract class AbstractClass
    {
        public void TemplateMethod() //模板方法
        {
            SpecificMethod();
            AbstractMethod1();
            AbstractMethod2();
        }
        public void SpecificMethod() //具体方法
        {
            Console.WriteLine("抽象类中的具体方法被调用...");
        }
        public abstract void AbstractMethod1(); //抽象方法1
        public abstract void AbstractMethod2(); //抽象方法2
    }
}
