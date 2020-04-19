using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Mediator
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    abstract class Mediator
    {
        public abstract void Register(Colleague colleague);
        public abstract void Relay(Colleague cl); //转发
    }
}
