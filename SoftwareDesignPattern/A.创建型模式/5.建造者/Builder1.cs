using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Builder
{
    /// <summary>
    /// 具体建造者1
    /// </summary>
    public class Builder1 : BaseBuilder
    {
        public override void BuilderPartA()
        {
            product.SetPartA("建造者1建造PartA");
        }

        public override void BuilderPartB()
        {
            product.SetPartB("建造者1建造PartB");
        }

        public override void BuilderPartC()
        {
            product.SetPartC("建造者1建造PartC");
        }
    }
}
