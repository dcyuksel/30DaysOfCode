namespace Day18
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Stack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            var lastIndex = this.items.Count - 1;

            if (lastIndex == -1)
            {
                throw new InvalidOperationException("Empty Stack");
            }

            var lastItem = this.items.ElementAt(lastIndex);
            this.items.RemoveAt(lastIndex);
            return lastItem;
        }
    }
}
