using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Interpreter
{
    /// <summary>
    /// 终结符表达式类
    /// </summary>
    class TerminalExpression : IAbstractExpression
    {
        public object Interpret(string info)
        {
            // 对终结符表达式的处理
            return null;
        }
    }

    /// <summary>
    /// 非终结符表达式类
    /// </summary>
    class NonterminalExpression : IAbstractExpression
    {
        private IAbstractExpression exp1;
        private IAbstractExpression exp2;

        public object Interpret(string info)
        {
            //非对终结符表达式的处理
            return null;
        }
    }
}
