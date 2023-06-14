using System.Reflection;
using Reflection.Enum;

namespace Reflection.Providers
{
    public interface IConfigurationProvider
    {
        ProviderType ProviderType { get; }

        string FilePath { get; set; }

        object LoadSettings(PropertyInfo info, string settingName);

        void SaveSettings(string key, object value);
    }
}
