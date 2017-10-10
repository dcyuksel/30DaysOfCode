namespace Day19
{
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            var sum = 0;

            for (var i = 1; i < (n / 2) + 1; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum + n;
        }
    }
}
