using System;

using Microsoft.Extensions.Configuration;

using R5T.Scotia;


namespace R5T.Argos
{
    public static class ConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddGmailLessSecureAuthenticationConfiguration(this IConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.AddUserSecretsFileRivetLocation(FileNames.GmailLessSecureConfigurationJsonFileName);

            return configurationBuilder;
        }
    }
}
