namespace Day5
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            GetMultiples(n);
        }

        private static void GetMultiples(int number)
        {
            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine(@"" + number + " x " + i + " = " +  number * i);
            }
        }
    }
}
