using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern
{
    public interface IFactory
    {
        BaseProduct GetProduct();
    }
}
