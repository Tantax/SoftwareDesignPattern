using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Mediator
{
    /// <summary>
    /// 具体同事类1
    /// </summary>
    class ConcreteColleague1 : Colleague
    {
        public override void Receive()
        {
            Console.WriteLine("具体同事类1收到请求。");
        }
        public override void Send()
        {
            Console.WriteLine("具体同事类1发出请求。");
            mediator.Relay(this); //请中介者转发
        }
    }

    /// <summary>
    /// 具体同事类2
    /// </summary>
    class ConcreteColleague2 : Colleague
    {
        public override void Receive()
        {
            Console.WriteLine("具体同事类2收到请求。");
        }
        public override void Send()
        {
            Console.WriteLine("具体同事类2发出请求。");
            mediator.Relay(this); //请中介者转发
        }
    }
}
