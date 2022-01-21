using Microsoft.Extensions.DependencyInjection;
using StrategyDesignPattern.Business.Services;

namespace StrategyDesignPattern.Business
{
    public static class BusinessServiceExtension
    {
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IShippingContext, ShippingContext>();
        }
    }
}
