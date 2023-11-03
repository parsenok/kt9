using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt9
{
    class Calculator<T> where T : new ()
    {
        public static T Add(T x, T y)
        {
            dynamic X = x;
            dynamic Y = y;
            return X + Y;
        }
        public T Zero()
        {
            return new T();
        }
    }
}
