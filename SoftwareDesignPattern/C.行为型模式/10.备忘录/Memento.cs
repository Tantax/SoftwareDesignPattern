using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Memento
{
    /// <summary>
    /// 备忘录
    /// </summary>
    class Memento
    {
        private string state;
        public Memento(string state)
        {
            this.state = state;
        }
        public void SetState(string state)
        {
            this.state = state;
        }
        public string GetState()
        {
            return state;
        }
    }
}
