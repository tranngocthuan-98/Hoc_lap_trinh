using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminAPI
{
    public static class FactoryPattern<K,T> where T : class, K, new()
    {
        public static K GetInstance()
        {
            K objk;
            objk = new T();
            return objk;
        }
    }
}
