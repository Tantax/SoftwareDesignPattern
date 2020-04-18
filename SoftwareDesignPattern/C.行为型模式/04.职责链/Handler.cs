using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.ChainOfResponsibility
{
    abstract class Handler
    {
        private Handler next = null;


        public void SetNext(Handler next)
        {
            this.next = next;
        }

        public Handler GetNext()
        {
            return this.next;
        }

        public abstract void HandleRequest(string request);
    }
}
