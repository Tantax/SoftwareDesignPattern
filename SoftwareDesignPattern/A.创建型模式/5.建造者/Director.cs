using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Builder
{
    /// <summary>
    /// 指挥者
    /// </summary>
    public class Director
    {
        private BaseBuilder builder;
        public Director(BaseBuilder builder)
        {
            this.builder = builder;
        }

        public Product Construct()
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
            builder.BuilderPartC();

            return builder.GetResult();
        }
    }
}
