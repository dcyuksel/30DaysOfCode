namespace Day6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            var outputs = new List<string>();

            for (var a0 = 0; a0 < t; a0++)
            {
                var input = Console.ReadLine();
                outputs.Add(GetOutput(input));
            }

            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
        }

        private static string GetOutput(string input)
        {
            var output1 = string.Empty;
            var output2 = string.Empty;
            var length = input.Length;

            if (length % 2 == 1)
            {
                for (var i = 0; i < length-1; i = i + 2)
                {
                    output1 += input.ElementAt(i);
                    output2 += input.ElementAt(i + 1);
                }

                return output1 + input.ElementAt(length - 1) + " " + output2;
            }

            for (var i = 0; i < length; i = i+2)
            {
                output1 += input.ElementAt(i);
                output2 += input.ElementAt(i+1);
            }

            return output1 + " " + output2;
        }
    }
}
