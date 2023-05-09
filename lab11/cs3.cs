using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class cs3
    {
        internal class Sum<T>
        {
            public T sum<T>(T[] array)
            {
                dynamic sum = default(T);

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                return sum;
            }
        }
        public static void task_3()
        {
            Sum<int> sum = new Sum<int>();
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };
            int intSum = sum.sum(intArray);
            Console.WriteLine($"intSum:{intSum} ");
            Console.WriteLine();

        }
    }

}
