using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Strategy
{
    /// <summary>
    /// 具体策略类A
    /// </summary>
    class ConcreteStrategyA : IStrategy
    {
        public void StrategyMethod()
        {
            Console.WriteLine("具体策略A的策略方法被访问！");
        }
    }

    /// <summary>
    /// 具体策略类B
    /// </summary>
    class ConcreteStrategyB : IStrategy
    {
        public void StrategyMethod()
        {
            Console.WriteLine("具体策略B的策略方法被访问！");
        }
    }
}
