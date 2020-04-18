using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Command
{
    /// <summary>
    /// 调用者
    /// </summary>
    class Invoker
    {
        private ICommand command = null;

        public Invoker(ICommand command)
        {
            this.command = command;
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Call()
        {
            command.Execute();
        }
    }
}
