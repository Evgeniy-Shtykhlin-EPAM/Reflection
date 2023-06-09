﻿using Reflection.Attribute;
using Reflection.Enum;
using Reflection.Providers;

namespace Reflection.Configuration
{
    public class ConfigurationSettings : ConfigurationComponentBase
    {
        public ConfigurationSettings(IProviders providersFactory) : base(providersFactory)
        {
        }

        public ConfigurationSettings(string name, TimeSpan? duration, int? number, float? floatNumber, IProviders providers)
            : base(providers)
        {
            Name = name;
            Duration = duration;
            Number = number;
            FloatNumber = floatNumber;
        }

        [ConfigurationItem("Name", ProviderType.File)]
        public string? Name { get; set; }

        [ConfigurationItem("Duration", ProviderType.File)]
        public TimeSpan? Duration { get; set; }

        [ConfigurationItem("Number", ProviderType.File)]
        public int? Number { get; set; }

        [ConfigurationItem("FloatNumber", ProviderType.File)]
        public float? FloatNumber { get; set; }
    }
}
