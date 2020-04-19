using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Memento
{
    /// <summary>
    /// 管理者
    /// </summary>
    class Caretaker
    {
        private Memento memento;
        public void SetMemento(Memento m)
        {
            memento = m;
        }
        public Memento GetMemento()
        {
            return memento;
        }
    }
}
