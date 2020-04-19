using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Visitor
{
    /// <summary>
    /// 具体访问者A类
    /// </summary>
    class ConcreteVisitorA : IVisitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine("具体访问者A访问-->" + element.OperationA());
        }

        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine("具体访问者A访问-->" + element.OperationB());
        }
    }

    /// <summary>
    /// 具体访问者B类
    /// </summary>
    class ConcreteVisitorB : IVisitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine("具体访问者B访问-->" + element.OperationA());
        }

        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine("具体访问者B访问-->" + element.OperationB());
        }
    }
}
