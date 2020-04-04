using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Adapter
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class ClassAdapter : ITarget
    {
        public void Request()
        {
            var rq = new Adaptee();
            rq.SpecialRequest();
        }
    }
}
