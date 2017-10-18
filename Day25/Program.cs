namespace Day25
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numberOfTestCases = Convert.ToInt16(Console.ReadLine());

            for (var i = 0; i < numberOfTestCases; i++)
            {
                var number = Convert.ToInt64(Console.ReadLine());

                PrintNumberIsPrimeOrNot(number);
            }
        }

        private static void PrintNumberIsPrimeOrNot(long number)
        {
            if (number <= 1)
            {
                Console.WriteLine("Not prime");
                return;
            }
            if (number <= 3)
            {
                Console.WriteLine("Prime");
                return;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                Console.WriteLine("Not prime");
                return;
            }

            for (var i = 5; i * i <= number; i = i + 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    Console.WriteLine("Not prime");
                    return;
                }
            }

            Console.WriteLine("Prime");
        }
    }
}
