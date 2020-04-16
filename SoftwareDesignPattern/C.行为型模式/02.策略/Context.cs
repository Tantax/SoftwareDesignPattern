using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Strategy
{
    /// <summary>
    /// 环境类
    /// </summary>
    class Context
    {
        private IStrategy strategy;
        public IStrategy GetStrategy()
        {
            return strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void StrategyMethod()
        {
            strategy.StrategyMethod();
        }
    }
}
