using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Command
{
    /// <summary>
    /// 具体命令A
    /// </summary>
    class ConcreteCommandA : ICommand
    {
        private readonly Receiver receiverA = new Receiver();

        public void Execute()
        {
            receiverA.Action();
        }
    }

    /// <summary>
    /// 具体命令B
    /// </summary>
    class ConcreteCommandB : ICommand
    {
        private readonly Receiver receiverB = new Receiver();

        public void Execute()
        {
            receiverB.Action();
        }
    }
}
