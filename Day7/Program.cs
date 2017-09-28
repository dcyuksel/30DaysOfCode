using System.Linq;

namespace Day7
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var length = Convert.ToInt32(Console.ReadLine());
            var array = Console.ReadLine().Split(' ');

            for (var i = length - 1; i > 0; i--)
            {
                Console.Write(array.ElementAt(i) + " ");
            }

            Console.Write(array.First());
        }
    }
}
