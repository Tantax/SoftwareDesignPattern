using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Composite
{
    /// <summary>
    /// 树枝构件
    /// </summary>
    class Composite : IComponent
    {
        private readonly List<IComponent> Children = new List<IComponent>();

        public void Add(IComponent c)
        {
            Children.Add(c);
        }
        public void Remove(IComponent c)
        {
            Children.Remove(c);
        }
        public IComponent GetChild(int i)
        {
            return Children[i];
        }

        public void Operation()
        {
            foreach (var item in Children)
            {
                item.Operation();
            }
        }
    }
}
