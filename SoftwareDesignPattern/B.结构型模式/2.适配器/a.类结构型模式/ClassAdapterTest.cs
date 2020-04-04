using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern.Adapter
{
    public class ClassAdapterTest
    {
        /// <summary>
        /// main
        /// </summary>
        public void Run()
        {
            var rq = new ClassAdapter();
            rq.Request();
        }
    }
}
