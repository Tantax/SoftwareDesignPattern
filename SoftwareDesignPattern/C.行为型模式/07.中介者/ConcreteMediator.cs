using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Mediator
{
    /// <summary>
    /// 具体中介者
    /// </summary>
    class ConcreteMediator : Mediator
    {
        private List<Colleague> colleagues = new List<Colleague>();

        public override void Register(Colleague colleague)
        {
            if (!colleagues.Contains(colleague))
            {
                colleagues.Add(colleague);
                colleague.SetMedium(this);
            }
        }

        public override void Relay(Colleague cl)
        {
            foreach (Colleague ob in colleagues)
            {
                if (!ob.Equals(cl))
                {
                    ob.Receive();
                }
            }
        }
    }
}
