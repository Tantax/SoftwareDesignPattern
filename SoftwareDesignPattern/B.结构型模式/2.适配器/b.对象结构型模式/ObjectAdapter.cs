using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Adapter
{
    public class ObjectAdapter : ITarget
    {
        private Adaptee _adaptee = null;
        public ObjectAdapter(Adaptee adp)
        {
            _adaptee = adp;
        }

        public void Request()
        {
            _adaptee.SpecialRequest();
        }
    }
}
