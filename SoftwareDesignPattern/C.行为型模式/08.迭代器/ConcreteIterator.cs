using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Iterator
{
    /// <summary>
    /// 具体迭代器
    /// </summary>
    class ConcreteIterator : ITerator
    {
        private List<Object> list = null;
        private int index = -1;
        public ConcreteIterator(List<Object> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            this.list = list;
        }
        public bool HasNext()
        {
            if (index < list.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Object First()
        {
            index = 0;
            object obj;
            if (list.Count > 0)
                obj = list[index];
            else
                obj = null;

            return obj;
        }
        public Object Next()
        {
            Object obj = null;
            if (this.HasNext())
            {
                obj = list[++index];
            }
            return obj;
        }
    }
}
