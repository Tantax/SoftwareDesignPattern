using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Builder
{
    /// <summary>
    /// 具体建造者2
    /// </summary>
    public class Builder2 : BaseBuilder
    {
        public override void BuilderPartA()
        {
            product.SetPartA("建造者2建造PartA");
        }

        public override void BuilderPartB()
        {
            product.SetPartB("建造者2建造PartB");
        }

        public override void BuilderPartC()
        {
            product.SetPartC("建造者2建造PartC");
        }
    }
}
