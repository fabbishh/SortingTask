using System.Text;
using System.Text.Json;

namespace SortingTask.Helpers
{
    static class DataSender
    {
        public static async Task SendNumbersToApi(List<int> numbers, HttpClient client)
        {
            try
            {
                var jsonData = JsonSerializer.Serialize(numbers);

                using StringContent content = new StringContent(
                    jsonData,
                    Encoding.UTF8,
                    "application/json");

                using HttpResponseMessage response = await client.PostAsync("numbers", content);
                response.EnsureSuccessStatusCode();

                Console.WriteLine("Data sent");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("An error has occurred: " + ex.Message);
            }
        }
    }
}
