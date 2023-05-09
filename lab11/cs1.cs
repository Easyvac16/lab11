using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class cs1
    {
        internal class Max<T>
        {
           public T max(T first ,T second ,T third)
           {
                dynamic a = first;
                dynamic b = second;
                dynamic c = third;
                int f = Math.Max(a, b);
                return Math.Max(f, c);
           }
        }
        public static void task_1()
        {
           Max<int> max = new Max<int>();
           Console.WriteLine("Max of 3 numbers:" + max.max(5, 2, 9));
           Console.WriteLine();

        }
    }
}
