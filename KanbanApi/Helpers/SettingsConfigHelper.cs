using Microsoft.Extensions.Configuration;
using System.IO;

namespace KanbanApi.Helpers
{
    public class SettingsConfigHelper
    {
        private static SettingsConfigHelper _appSettings;
        public string appSettingValue { get; set; }

        public static string AppSetting(string key)
        {
            _appSettings = GetCurrentSettings(key);
            return _appSettings.appSettingValue;
        }

        public SettingsConfigHelper(IConfiguration config, string key)
        {
            this.appSettingValue = config.GetValue<string>(key);
        }

        public static SettingsConfigHelper GetCurrentSettings(string key)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            var settings = new SettingsConfigHelper(configuration.GetSection("Secret"), key);

            return settings;
        }
    }
}
