using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.State
{
    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("当前状态是 A.");
            context.State = new ConcreteStateB();
        }
    }

    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("当前状态是 B.");
            context.State = new ConcreteStateA();
        }
    }
}
