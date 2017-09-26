namespace Day1
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            var integerFromConsole = Convert.ToInt32(Console.ReadLine());
            var doubleFromConsole = Double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            var stringFromConsole = Console.ReadLine();

            Console.WriteLine(i + integerFromConsole);
            Console.WriteLine($"{d + doubleFromConsole:0.0}");
            Console.WriteLine(s + stringFromConsole);
        }
    }
}
