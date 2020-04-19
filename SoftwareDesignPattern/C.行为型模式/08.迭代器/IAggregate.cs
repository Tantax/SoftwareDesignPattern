using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Iterator
{
    /// <summary>
    /// 抽象聚合
    /// </summary>
    interface IAggregate
    {
        void Add(Object obj);
        void Remove(Object obj);
        ITerator GetIterator();
    }
}
