namespace Day2
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var mealCost = Double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            var tipPercent = Convert.ToInt32(Console.ReadLine());
            var taxPercent = Convert.ToInt32(Console.ReadLine());

            var totalCost = mealCost +
                            GetPercentOfADouble(mealCost, tipPercent) +
                            GetPercentOfADouble(mealCost, taxPercent);

            Console.WriteLine(@"The total meal cost is " + Math.Round(totalCost) + " dollars.");
        }

        private static double GetPercentOfADouble(double number, int percent)
        {
            return (number * percent) / 100;
        }
    }
}
