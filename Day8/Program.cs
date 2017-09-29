namespace Day8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>();
            var t = Convert.ToInt32(Console.ReadLine());

            for (var a0 = 0; a0 < t; a0++)
            {
                var input = Console.ReadLine();
                var parsedInput = input.Split(' ');
                dictionary.Add(parsedInput.ElementAt(0), parsedInput.ElementAt(1));
            }

            while (true)
            {
                var key = Console.ReadLine();
                string output;
                Console.WriteLine(dictionary.TryGetValue(key, out output) 
                    ? key + "=" + output
                    : "Not found");
            }
        }
    }
}
