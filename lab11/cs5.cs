using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class Queue<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return items[items.Count - 1];
        }
    }
    internal class cs5
    {
        public static void task_5()
        {
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);
            intQueue.Enqueue(4);
            intQueue.Enqueue(5);
            intQueue.Enqueue(6);

            Console.WriteLine($"Queue: {intQueue.Count}");

            Console.WriteLine($"Peek: {intQueue.Peek()}");

            Console.WriteLine($"Dequeue: {intQueue.Dequeue()}");

            Console.WriteLine($"Dequeue: {intQueue.Dequeue()}");

            Console.WriteLine($"Peek: {intQueue.Peek()}");

            Console.WriteLine($"Queue: {intQueue.Count}");
            Console.WriteLine();
        }
    }
}
