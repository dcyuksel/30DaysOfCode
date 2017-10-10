namespace Day18
{
    public class Solution
    {
        private Queue<char> queue;
        private Stack<char> stack;

        public Solution()
        {
            this.queue = new Queue<char>();
            this.stack = new Stack<char>();
        }

        public void pushCharacter(char c)
        {
            this.stack.Push(c);
        }

        public char popCharacter()
        {
            return this.stack.Pop();
        }

        public void enqueueCharacter(char c)
        {
            this.queue.Enqueue(c);
        }

        public char dequeueCharacter()
        {
            return this.queue.Dequeue();
        }
    }
}
