namespace Day3
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var tag = GetTagOfNumber(number);
            Console.WriteLine(tag == Tag.Weird ? "Weird" : "Not Weird");
        }

        private static Tag GetTagOfNumber(int number)
        {
            if (IsItOddOrNot(number))
            {
                return Tag.Weird;
            }

            if (number >= 2 && number <= 5)
            {
                return Tag.NotWeird;
            }

            if (number >= 6 && number <= 20)
            {
                return Tag.Weird;
            }

            return Tag.NotWeird;
        }

        private static bool IsItOddOrNot(int number)
        {
            return number % 2 != 0;
        }
    }

    internal enum Tag
    {
        Weird,
        NotWeird
    }
}
