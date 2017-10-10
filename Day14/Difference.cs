namespace Day14
{
    using System.Linq;

    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            var maxAbs = 0;

            for (var i = 0; i < this.elements.Length - 1; i++)
            {
                for (var j = i + 1; j < this.elements.Length; j++)
                {
                    var absDifference = GetAbsoluteDifferenceBetweenTwoNumbers(this.elements.ElementAt(i), this.elements.ElementAt(j));
                    if (absDifference > maxAbs)
                    {
                        maxAbs = absDifference;
                    }
                }
            }

            this.maximumDifference = maxAbs;
        }

        private static int GetAbsoluteDifferenceBetweenTwoNumbers(int a, int b)
        {
            return a >= b ? a - b : b - a;
        }
    }
}
