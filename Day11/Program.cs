using System;

namespace Day11
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var arr = new int[6][];

            for (var row = 0; row < 6; row++)
            {
                var temp = Console.ReadLine().Split(' ');
                arr[row] = Array.ConvertAll(temp, int.Parse);
            }

            Console.WriteLine(GetLargestHourGlassSum(arr));
        }

        private static int GetLargestHourGlassSum(int[][] arr)
        {
            var largest = -72;

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    var sum = GetHourGlassSum(arr, i, j);

                    if (largest < sum)
                    {
                        largest = sum;
                    }
                }
            }

            return largest;
        }

        private static int GetHourGlassSum(int[][] arr, int rowIndex, int coloumnIndex)
        {
            var sum = 0;

            for (var i = rowIndex; i < rowIndex + 3; i++)
            {
                if (i == rowIndex + 1)
                {
                    sum += arr[i][coloumnIndex + 1];
                    continue;
                }

                for (var j = coloumnIndex; j < coloumnIndex + 3; j++)
                {
                    sum += arr[i][j];
                }
            }

            return sum;
        }
    }
}
