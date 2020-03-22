using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Builder
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class BaseBuilder
    {
        protected Product product = new Product();

        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract void BuilderPartC();

        public Product GetResult()
        {
            return product;
        }
    }
}
