using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt9
{
    class Pair<T, U> where T : class where U : class
    {
        public T A { get; set; } 
        public U B { get; set; }
        public Pair(T a, U b) 
        {
            this.A = a;
            this.B = b;
        }
        public void Swap() 
        {
            T swap = A;
            A = B as T;
            B = swap as U;
        }
    }
}
