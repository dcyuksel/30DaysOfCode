using System.Linq;

namespace Day10
{
    using System;

    public class Program
    {
        public static void Main(String[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var binaryFormOfN = GetBinary(n);
            Console.WriteLine(GetMaxNumberOfConsecutive1(binaryFormOfN));
        }

        private static int GetMaxNumberOfConsecutive1(string binaryFormOfN)
        {
            var max = 0;
            var previous = false;
            var counterForConsecutives = 0;

            for (var i = 0; i < binaryFormOfN.Length; i++)
            {
                if (binaryFormOfN.ElementAt(i) == '1')
                {
                    if (previous)
                    {
                        counterForConsecutives++;
                    }
                    else
                    {
                        previous = true;
                        counterForConsecutives++;
                    }
                }
                else
                {
                    if (counterForConsecutives > max)
                    {
                        max = counterForConsecutives;
                    }

                    counterForConsecutives = 0;
                    previous = false;
                }
            }

            if (counterForConsecutives > max)
            {
                max = counterForConsecutives;
            }

            return max;
        }

        private static string GetBinary(int number)
        {
            var binaryForm = string.Empty;

            while (number > 0)
            {
                binaryForm = (number % 2) + binaryForm;
                number /= 2;
            }

            return binaryForm;
        }
    }
}
