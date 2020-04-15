using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Decorator
{
    class ConcreteDecorator1 : Decorator
    {
        public ConcreteDecorator1(IComponent component) : base(component)
        {

        }

        public new void Operation()
        {
            base.Operation();
            AddFunction1();
        }

        public void AddFunction1()
        {

        }
    }

    class ConcreteDecorator2 : Decorator
    {
        public ConcreteDecorator2(IComponent component) : base(component)
        {

        }

        public new void Operation()
        {
            base.Operation();
            AddFunction2();
        }

        public void AddFunction2()
        {

        }
    }
}
