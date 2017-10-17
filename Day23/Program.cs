namespace Day23
{
    using System;

    public class Program
    {

        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }

        private static void levelOrder(Node root)
        {
            if (root == null) return;
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (!queue.IsEmpty())
            {
                var currentNode = queue.Dequeue();
                Console.Write(currentNode.data + " ");

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
        }

        private static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
}
