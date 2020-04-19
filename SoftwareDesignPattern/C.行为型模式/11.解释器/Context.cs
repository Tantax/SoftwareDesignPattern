using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Interpreter
{
    class Context
    {
        private IAbstractExpression exp;
        public Context()
        {
            //数据初始化
        }
        public void Operation(string info)
        {
            //调用相关表达式类的解释方法
        }
    }
}
