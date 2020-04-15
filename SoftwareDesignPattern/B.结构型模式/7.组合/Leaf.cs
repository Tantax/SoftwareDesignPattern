using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Composite
{
    /// <summary>
    /// 树叶构件
    /// </summary>
    class Leaf : IComponent
    {
        private string Name { get; set; }
        public Leaf(string name)
        {
            this.Name = name;
        }
        public void Operation()
        {
            // todo something
        }
    }
}
