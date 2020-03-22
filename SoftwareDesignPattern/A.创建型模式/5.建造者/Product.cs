using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Builder
{
    /// <summary>
    /// 产品
    /// </summary>
    public class Product
    {
        private string _partA;
        private string _partB;
        private string _partC;

        public void SetPartA(string partA)
        {
            _partA = partA;
        }
        public void SetPartB(string partB)
        {
            _partB = partB;
        }
        public void SetPartC(string partC)
        {
            _partC = partC;
        }

        public void Show()
        {
            Console.WriteLine(_partA + _partB + _partC);
        }
    }
}
