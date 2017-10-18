namespace Day26
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var returnedDate = Console.ReadLine().Split(' ').Select(element => Convert.ToInt32(element)).ToList();
            var expectedDate = Console.ReadLine().Split(' ').Select(element => Convert.ToInt32(element)).ToList();
            PrintFine(expectedDate, returnedDate);
        }

        private static void PrintFine(IList<int> expectedDate, IList<int> returnedDate)
        {
            if (returnedDate.ElementAt(2) < expectedDate.ElementAt(2))
            {
                Console.WriteLine(0);
                return;
            }
            if (returnedDate.ElementAt(2) == expectedDate.ElementAt(2) &&
                returnedDate.ElementAt(1) < expectedDate.ElementAt(1))
            {
                Console.WriteLine(0);
                return;
            }
            if (returnedDate.ElementAt(0) <= expectedDate.ElementAt(0) &&
                returnedDate.ElementAt(1) <= expectedDate.ElementAt(1) &&
                returnedDate.ElementAt(2) <= expectedDate.ElementAt(2))
            {
                Console.WriteLine(0);
                return;
            }
            if (returnedDate.ElementAt(1) <= expectedDate.ElementAt(1) &&
                returnedDate.ElementAt(2) <= expectedDate.ElementAt(2))
            {
                var passedDaysNumber = returnedDate.ElementAt(0) - expectedDate.ElementAt(0);
                Console.WriteLine(15 * passedDaysNumber);
                return;
            }
            if (returnedDate.ElementAt(2) <= expectedDate.ElementAt(2))
            {
                var passedMonthsNumber = returnedDate.ElementAt(1) - expectedDate.ElementAt(1);
                Console.WriteLine(500 * passedMonthsNumber);
                return;
            }

            Console.WriteLine(10000);
        }
    }
}
