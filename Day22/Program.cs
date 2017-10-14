namespace Day22
{
    using System;

    public class Program
    {
        public static void Main(String[] args)
        {
            Node root = null;
            var T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }

        private static int getHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            var leftHeight = getHeight(root.left);
            var rightHeight = getHeight(root.right);


            if (leftHeight >= rightHeight)
            {
                return leftHeight + 1;
            }

            return rightHeight + 1;
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
