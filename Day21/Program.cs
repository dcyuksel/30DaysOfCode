namespace Day21
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var intArray = new int[n];
            for (var i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            var stringArray = new string[n];
            for (var i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            PrintArray(intArray);
            PrintArray(stringArray);
        }

        private static void PrintArray<T>(T[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
