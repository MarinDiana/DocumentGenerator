using System;

namespace DocumentGenerator.Configuration
{
    public class AppConfiguration
    {
        private static readonly Lazy<AppConfiguration> instance =
            new Lazy<AppConfiguration>(() => new AppConfiguration());

        public static AppConfiguration Instance => instance.Value;

        public string OutputDirectory { get; private set; }
        public string DefaultAuthor { get; private set; }

        private AppConfiguration()
        {
            // valori default (simulam appsettings.json)
            OutputDirectory = "output/";
            DefaultAuthor = "Admin";
        }
    }
}