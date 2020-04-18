using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.State
{
    class Context
    {
        public Context()
        {
            State = new ConcreteStateA();
        }

        public State State { get; set; }


        public void Handle()
        {
            State.Handle(this);
        }
    }
}
