namespace SortingTask.Strategy
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<int> numbers);

        protected void Swap(List<int> numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
