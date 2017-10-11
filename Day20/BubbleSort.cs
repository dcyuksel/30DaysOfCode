namespace Day20
{
    using System.Linq;

    public class BubbleSort
    {
        private int numberOfSwaps;
        private int lengthOfArray;
        private int[] array;
        

        public BubbleSort(int[] array, int lengthOfArray)
        {
            this.numberOfSwaps = 0;
            this.lengthOfArray = lengthOfArray;
            this.array = array;
        }

        public Result Sort()
        {
            for (var i = 0; i < lengthOfArray; i++)
            {
                var numberOfSwapsInOneIteration = 0;

                for (var j = 0; j < lengthOfArray - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        this.Swap(j);
                        numberOfSwapsInOneIteration++;
                    }
                }

                if (numberOfSwapsInOneIteration == 0)
                {
                    break;
                }

                numberOfSwaps += numberOfSwapsInOneIteration;
            }

            return new Result
            {
                FirstElement = this.array.First(),
                LastElement = this.array.ElementAt(this.lengthOfArray - 1),
                NumberOfSwaps = this.numberOfSwaps
            };
        }

        private void Swap(int index)
        {
            var temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}
