using System;

using Microsoft.Extensions.Configuration;

using R5T.Scotia;


namespace R5T.Argos.Code.Extensions
{
    public static class ConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddGmailLessSecureConfiguration(this IConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.AddUserSecretsFileRivetLocation(FileNames.GmailLessSecureConfigurationJsonFileName);

            return configurationBuilder;
        }
    }
}
