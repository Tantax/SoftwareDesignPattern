using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Adapter
{
    public class ObjectAdapterTest
    {
        /// <summary>
        /// main
        /// </summary>
        public void Run()
        {
            var ad = new Adaptee();
            var oa = new ObjectAdapter(ad);
            oa.Request();
        }
    }
}
