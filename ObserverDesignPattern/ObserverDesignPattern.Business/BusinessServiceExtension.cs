using Microsoft.Extensions.DependencyInjection;
using ObserverDesignPattern.Business.Services;
using System;

namespace ObserverDesignPattern.Business
{
    public static class BusinessServiceExtension
    {
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
        }
    }
}
