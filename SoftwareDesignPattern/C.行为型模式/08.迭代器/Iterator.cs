using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Iterator
{
    /// <summary>
    /// 抽象迭代器
    /// </summary>
    interface ITerator
    {
        Object First();
        Object Next();
        bool HasNext();
    }
}
