using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Adapter
{
    /// <summary>
    /// 适配者
    /// </summary>
    public class Adaptee
    {
        public void SpecialRequest()
        {
            Console.WriteLine("适配者方法");
        }
    }
}
