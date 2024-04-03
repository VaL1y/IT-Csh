using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public class StackModel<T>
    {
        private Stack<T> stack;

        public StackModel()
        {
            stack = new Stack<T>();
        }

        public T CurrentElement
        {
            get { return stack.Count > 0 ? stack.Peek() : default(T); }
        }

        public int Count
        {
            get { return stack.Count; }
        }

        public bool IsEmpty
        {
            get { return stack.Count == 0; }
        }

        public void Push(T item)
        {
            stack.Push(item);
        }

        public T Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            return stack.Pop();
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}
