using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Bridge
{
    /// <summary>
    /// 抽象化角色
    /// </summary>
    internal abstract class Abstraction
    {
        protected IImplementor imple;
        protected Abstraction(IImplementor imple)
        {
            this.imple = imple;
        }

        public abstract void Operation();
    }
}
