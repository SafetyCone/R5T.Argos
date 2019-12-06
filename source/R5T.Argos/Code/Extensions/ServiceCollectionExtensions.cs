using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Gimpolis;
using R5T.Sardinia;


namespace R5T.Argos
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGmailAuthentication(this IServiceCollection services)
        {
            services
                .AddOptions()
                .Configure<GmailAuthentication>()
                ;

            return services;
        }
    }
}
