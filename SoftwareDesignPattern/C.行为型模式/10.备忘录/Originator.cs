using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Memento
{
    /// <summary>
    /// 发起人
    /// </summary>
    class Originator
    {
        private string state;
        public void SetState(string state)
        {
            this.state = state;
        }
        public string GetState()
        {
            return state;
        }
        public Memento CreateMemento()
        {
            return new Memento(state);
        }
        public void RestoreMemento(Memento m)
        {
            this.SetState(m.GetState());
        }
    }
}
