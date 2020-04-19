using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Interpreter
{
    /// <summary>
    /// 抽象表达式类
    /// </summary>
    interface IAbstractExpression
    {
        object Interpret(string info);    //解释方法
    }
}
