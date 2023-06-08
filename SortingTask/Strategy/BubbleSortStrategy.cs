namespace SortingTask.Strategy
{
    public class BubbleSortStrategy : SortStrategy
    {
        public override void Sort(List<int> numbers)
        {
            int n = numbers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(numbers, j, j + 1);
                    }
                }
            }
        }
    }
}
