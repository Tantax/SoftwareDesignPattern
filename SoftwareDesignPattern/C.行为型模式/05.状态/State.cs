using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.State
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}
