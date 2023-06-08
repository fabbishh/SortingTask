namespace SortingTask.Strategy
{
    public class SelectionSortStrategy : SortStrategy
    {
        public override void Sort(List<int> numbers)
        {
            int n = numbers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                Swap(numbers, minIndex, i);
            }
        }
    }
}
