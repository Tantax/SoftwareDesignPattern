using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern
{
    /// <summary>
    /// 原型模式
    /// </summary>
    public class Prototype : ICloneable
    {
        public object Clone()
        {
            //return this.MemberwiseClone();// 浅拷贝
            return this.Copy<Prototype>();// 深拷贝
        }
    }
}
