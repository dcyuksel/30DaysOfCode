namespace Day9
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }

        public static int factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }

            return n * factorial(n - 1);
        }
    }
}
