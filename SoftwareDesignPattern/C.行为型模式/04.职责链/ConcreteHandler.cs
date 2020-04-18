using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.ChainOfResponsibility
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request.Equals("one"))
            {
                Console.WriteLine("具体处理者1负责处理该请求！");
            }
            else
            {
                if (GetNext() != null)
                {
                    GetNext().HandleRequest(request);
                }
                else
                {
                    Console.WriteLine("没有人处理该请求！");
                }
            }
        }
    }

    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request.Equals("two"))
            {
                Console.WriteLine("具体处理者2负责处理该请求！");
            }
            else
            {
                if (GetNext() != null)
                {
                    GetNext().HandleRequest(request);
                }
                else
                {
                    Console.WriteLine("没有人处理该请求！");
                }
            }
        }
    }
}
