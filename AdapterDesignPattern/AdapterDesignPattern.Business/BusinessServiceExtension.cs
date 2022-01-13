using AdapterDesignPattern.Business.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AdapterDesignPattern.Business
{
    public static class BusinessServiceExtension
    {
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddScoped<IAnalyticsAdapter, AnalyticsAdapter>();
            services.AddScoped<IAnalyticsService, AnalyticsService>();
        }
    }
}
