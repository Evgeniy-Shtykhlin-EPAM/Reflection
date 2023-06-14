using Reflection.Enum;

namespace Reflection.Providers
{
    public interface IProviders
    {
        IConfigurationProvider GetProvider(ProviderType providerType);
    }
}
