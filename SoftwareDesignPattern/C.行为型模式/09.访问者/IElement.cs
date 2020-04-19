using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Visitor
{
    /// <summary>
    /// 抽象元素类
    /// </summary>
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
