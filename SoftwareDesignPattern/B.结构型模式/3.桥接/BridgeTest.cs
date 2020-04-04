using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Bridge
{
    public class BridgeTest
    {
        /// <summary>
        /// main
        /// </summary>
        public void Run()
        {
            IImplementor imple = new ConcreteImplementorA();
            Abstraction abs = new RefinedAbstraction(imple);
            abs.Operation();
        }
    }
}
