using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Subject
{
    /// <summary>
    /// 代理
    /// </summary>
    public class Proxy : ISubject
    {
        private Subject _realSubject;

        public void PreRequest()
        {
            Console.WriteLine("访问真实主题之前的预处理");
        }
        public void Request()
        {
            if (_realSubject == null)
                _realSubject = new Subject();

            PreRequest();
            _realSubject.Request();
            PostRequest();
        }
        public void PostRequest()
        {
            Console.WriteLine("访问真实主题之后的后续处理");
        }
    }
}
