using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Subject
{
    /// <summary>
    /// 主题
    /// </summary>
    public class Subject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("访问真实主题方法...");
        }
    }
}
