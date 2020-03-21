using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        private static readonly object _lockObj = new object();
        private Singleton() { }


        #region 懒汉式单例
        private static Singleton _obj;
        public static Singleton GetLazyInstance()
        {
            lock (_lockObj)
            {
                if (_obj == null)
                {
                    _obj = new Singleton();
                }
            }
            return _obj;
        }
        #endregion

        #region 饿汉式单例
        public static readonly Singleton _obj2 = new Singleton();
        public static Singleton GetHungryInstance()
        {
            return _obj2;
        } 
        #endregion
    }



}
