using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Visitor
{
    /// <summary>
    /// 对象结构角色
    /// </summary>
    class ObjectStructure
    {
        private List<IElement> list = new List<IElement>();
        public void Accept(IVisitor visitor)
        {
            var i = list.GetEnumerator();
            while (i.MoveNext())
            {
                i.Current.Accept(visitor);
            }
        }
        public void Add(IElement element)
        {
            list.Add(element);
        }
        public void Remove(IElement element)
        {
            list.Remove(element);
        }
    }
}
