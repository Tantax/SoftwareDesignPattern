using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Decorator
{
    abstract class Decorator : IComponent
    {
        private IComponent Component { get; set; }

        public Decorator(IComponent component)
        {
            this.Component = component;
        }

        public void Operation()
        {
            Component.Operation();
        }
    }
}
