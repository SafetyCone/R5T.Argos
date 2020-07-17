using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using R5T.Dacia;
using R5T.Gimpolis;
using R5T.Sardinia;


namespace R5T.Argos
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IOptions{TOptions}"/> of <see cref="GmailAuthentication"/> service.
        /// </summary>
        public static IServiceCollection AddGmailAuthentiation(this IServiceCollection services)
        {
            services.Configure<GmailAuthentication>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOptions{TOptions}"/> of <see cref="GmailAuthentication"/> service.
        /// </summary>
        public static IServiceAction<IOptions<GmailAuthentication>> AddGmailAuthentiationAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IOptions<GmailAuthentication>>(() => services.AddGmailAuthentiation());
            return serviceAction;
        }
    }
}
