namespace KanbanApi.Helpers
{
    public class Settings
    {
        public string GetSecret()
        {
            return SettingsConfigHelper.AppSetting("Key");
        }

        public string GetLogin()
        {
            return SettingsConfigHelper.AppSetting("Login");
        }

        public string GetPassword()
        {
            return SettingsConfigHelper.AppSetting("Senha");
        }
    }
}
