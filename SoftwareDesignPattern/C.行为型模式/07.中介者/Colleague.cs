using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Mediator
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    abstract class Colleague
    {
        protected Mediator mediator;
        public void SetMedium(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public abstract void Receive();
        public abstract void Send();
    }
}
