using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Bridge
{
    /// <summary>
    /// 具体实现化角色
    /// </summary>
    public class ConcreteImplementorA : IImplementor
    {
        public void OperationImpl()
        {
            Console.WriteLine("A的方法");
        }
    }

    /// <summary>
    /// 具体实现化角色
    /// </summary>
    public class ConcreteImplementorB : IImplementor
    {
        public void OperationImpl()
        {
            Console.WriteLine("B的方法");
        }
    }
}
