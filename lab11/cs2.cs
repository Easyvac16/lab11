using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class cs2
    {
        internal class Min<T>
        {
            public T min(T first, T second, T third)
            {
                dynamic a = first;
                dynamic b = second;
                dynamic c = third;
                int f = Math.Min(a, b);
                return Math.Min(f, c);
            }
        }
        public static void task_2()
        {
            Min<int> min = new Min<int>();
            Console.WriteLine("Min of 3 numbers:" + min.min(5, 2, 9));
            Console.WriteLine();

        }
    }
}
