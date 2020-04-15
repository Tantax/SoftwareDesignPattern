using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Facade
{
    class Facade
    {
        private SubSystem1 obj1 = new SubSystem1();
        private SubSystem2 obj2 = new SubSystem2();
        private SubSystem3 obj3 = new SubSystem3();
        public void Method()
        {
            obj1.Method1();
            obj2.Method2();
            obj3.Method3();
        }
    }
}
