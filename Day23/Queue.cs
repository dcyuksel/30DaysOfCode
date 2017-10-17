namespace Day23
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Queue<T>
    {
        private List<T> items = new List<T>();

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            var lastIndex = this.items.Count - 1;

            if (lastIndex == -1)
            {
                throw new InvalidOperationException("Empty Queue");
            }

            var dequeuedItem = this.items.ElementAt(0);
            this.items.RemoveAt(0);
            return dequeuedItem;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}
