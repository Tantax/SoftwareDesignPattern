using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignPattern
{
    public static class DBMaper
    {
        public static T Copy<T>(this object source)
            where T : new()
        {
            if (source == null)
                return default;

            T re = new T();
            var pList = typeof(T).GetProperties();
            var sType = source.GetType();
            foreach (var pInfo in pList)
            {
                var sInfo = sType.GetProperty(pInfo.Name);
                if (sInfo != null)
                {
                    pInfo.SetValue(re, sInfo.GetValue(source));
                }
            }

            return re;
        }
    }
}
