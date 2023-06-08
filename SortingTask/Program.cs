using SortingTask.Helpers;

namespace SortingTask
{
    class Program
    {
        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri(ConfigReader.ApiUrl),
        };

        static async Task Main(string[] args)
        {
            var rg = new RandomGenerator();
            var numbers = rg.GenerateRandomNumbers();

            Console.WriteLine("Initial values:");
            PrintNumbers(numbers);

            var sortStrategy = rg.GetRandomSortStrategy();
            var sorter = new Sorter(sortStrategy);
            sorter.SortNumbers(numbers);

            Console.WriteLine("Sorted values:");
            PrintNumbers(numbers);

            await DataSender.SendNumbersToApi(numbers, sharedClient);

            Console.ReadLine();
        }

        static void PrintNumbers(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
