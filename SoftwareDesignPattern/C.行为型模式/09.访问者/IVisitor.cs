using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Visitor
{
    /// <summary>
    /// 抽象访问者
    /// </summary>
    interface IVisitor
    {
        void Visit(ConcreteElementA element);
        void Visit(ConcreteElementB element);
    }
}
