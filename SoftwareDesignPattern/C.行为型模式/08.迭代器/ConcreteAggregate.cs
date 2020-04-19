using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Iterator
{
    /// <summary>
    /// 具体聚合
    /// </summary>
    class ConcreteAggregate : IAggregate
    {
        private List<Object> list = new List<Object>();

        public void Add(object obj)
        {
            list.Add(obj);
        }

        public ITerator GetIterator()
        {
            return new ConcreteIterator(list);
        }

        public void Remove(object obj)
        {
            list.Remove(obj);
        }
    }
}
