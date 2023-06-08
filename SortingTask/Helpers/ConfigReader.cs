using System.Configuration;

namespace SortingTask.Helpers
{
    public static class ConfigReader
    {
        public static string ApiUrl => ConfigurationManager.AppSettings["ApiUrl"];
    }
}
