using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Flyweight
{
    interface IFlyweight
    {
        void Operation(UnsharedConcreteFlyweight state);
    }
}
