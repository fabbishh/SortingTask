using SortingTask.Strategy;

namespace SortingTask.Helpers
{
    public class Sorter
    {
        private SortStrategy _sortStrategy;

        public Sorter(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SortNumbers(List<int> numbers)
        {
            _sortStrategy.Sort(numbers);
        }
    }
}
