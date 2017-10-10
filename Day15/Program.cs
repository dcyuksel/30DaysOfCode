namespace Day15
{
    using System;

    public class Program
    {
        public static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }
            else if (head.next != null)
            {
                insert(head.next, data);
            }
            else
            {
                var newNode = new Node(data);
                head.next = newNode;
            }

            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
