using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace Reader.Data
{
    public class Utility
    {
        public static string GetConnectionString(string key)
        {
            // Defines the sources of configuration information for the
            // application.
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            // Create the configuration object that the application will
            // use to retrieve configuration information.
            var configuration = builder.Build();
            // Retrieve the configuration information.
            var configValue = configuration[key];
            return configValue;
        }
    }
}