using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Bridge
{
    /// <summary>
    /// 扩展抽象化角色
    /// </summary>
    internal class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor imple) : base(imple)
        {
            
        }

        public override void Operation()
        {
            imple.OperationImpl();
        }
    }
}
