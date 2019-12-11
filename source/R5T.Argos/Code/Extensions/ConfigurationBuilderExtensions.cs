using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Suebia;


namespace R5T.Argos
{
    public static class ConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddGmailLessSecureAuthenticationConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            var secretsFilePathProvider = configurationServiceProvider.GetRequiredService<ISecretsFilePathProvider>();

            var secretsFilePath = secretsFilePathProvider.GetSecretsFilePath(FileNames.GmailLessSecureConfigurationJsonFileName);

            configurationBuilder.AddJsonFile(secretsFilePath);

            return configurationBuilder;
        }
    }
}
