using SortingTask.Enums;
using SortingTask.Strategy;

namespace SortingTask.Helpers
{
    public class RandomGenerator
    {
        public List<int> GenerateRandomNumbers()
        {
            var random = new Random();
            var count = random.Next(20, 101);

            var numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(-100, 101));
            }

            return numbers;
        }

        public SortStrategy GetRandomSortStrategy()
        {
            var random = new Random();
            var values = Enum.GetValues(typeof(SortAlgorithm));
            var strategy = (SortAlgorithm)values.GetValue(random.Next(values.Length));

            switch (strategy)
            {
                case SortAlgorithm.BubbleSort:
                    return new BubbleSortStrategy();
                case SortAlgorithm.SelectionSort:
                    return new SelectionSortStrategy();
                default:
                    throw new Exception($"Стратегия не найдена.");
            }
        }
    }
}
