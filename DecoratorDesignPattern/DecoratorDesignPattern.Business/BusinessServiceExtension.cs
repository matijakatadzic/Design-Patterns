using DecoratorDesignPattern.Business.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DecoratorDesignPattern.Business
{
    public static class BusinessServiceExtension
    {
        public static void AddBusiness(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPlayersService, PlayersService>();

            if (Convert.ToBoolean(configuration["EnableCaching"]))
            {
                services.Decorate<IPlayersService, PlayersServiceCachingDecorator>();
            }

            if (Convert.ToBoolean(configuration["EnableLogging"]))
            {
                services.Decorate<IPlayersService, PlayersServiceLoggingDecorator>();
            }
        }
    }
}
