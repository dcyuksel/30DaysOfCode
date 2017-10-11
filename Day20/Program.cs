namespace Day20
{
    using System;

    public class Program
    {
        public static void Main(String[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var temp = Console.ReadLine().Split(' ');
            var intArray = Array.ConvertAll(temp, Int32.Parse);
            var bubleSort = new BubbleSort(intArray, n);
            var result = bubleSort.Sort();
            Console.WriteLine("Array is sorted in " + result.NumberOfSwaps + " swaps.");
            Console.WriteLine("First Element: " + result.FirstElement);
            Console.WriteLine("Last Element: " + result.LastElement);
        }
    }
}
