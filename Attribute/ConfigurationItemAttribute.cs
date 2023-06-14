
using Reflection.Enum;

namespace Reflection.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ConfigurationItemAttribute : System.Attribute
    {
        public ConfigurationItemAttribute(string settingName, ProviderType providerType)
        {
            SettingName = settingName;
            ProviderType = providerType;
        }

        public string SettingName { get; }

        public ProviderType ProviderType { get; }
    }
}
