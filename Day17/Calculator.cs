namespace Day17
{
    using System;

    public class Calculator
    {
        public int power(int n, int p)
        {
            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }

            return Convert.ToInt32(Math.Pow((double)n, (double)p));
        }
    }
}
