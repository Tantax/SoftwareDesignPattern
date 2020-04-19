using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Visitor
{
    /// <summary>
    /// 具体元素A类
    /// </summary>
    class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public string OperationA()
        {
            return "具体元素A的操作。";
        }
    }

    /// <summary>
    /// 具体元素B类
    /// </summary>
    class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public string OperationB()
        {
            return "具体元素B的操作。";
        }
    }
}
