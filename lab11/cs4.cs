using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class Stack<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
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
    internal class cs4
    {
        public static void task_4()
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            Console.WriteLine($"Count: {intStack.Count}"); 

            Console.WriteLine($"Peek: {intStack.Peek()}"); 

            Console.WriteLine($"Pop: {intStack.Pop()}"); 

            Console.WriteLine($"Peek: {intStack.Peek()}"); 

            Console.WriteLine($"Count: {intStack.Count}");
            Console.WriteLine();

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("one");
            stringStack.Push("two");
            stringStack.Push("three");

            Console.WriteLine($"Count: {stringStack.Count}"); 

            Console.WriteLine($"Peek: {stringStack.Peek()}"); 

            Console.WriteLine($"Pop: {stringStack.Pop()}"); 

            Console.WriteLine($"Peek: {stringStack.Peek()}"); 

            Console.WriteLine($"Count: {stringStack.Count}"); 
            Console.WriteLine();
        }
    }
}
