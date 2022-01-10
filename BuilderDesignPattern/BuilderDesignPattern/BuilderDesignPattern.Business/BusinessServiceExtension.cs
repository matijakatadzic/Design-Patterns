using BuilderDesignPattern.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BuilderDesignPattern.Business
{
    public static class BusinessServiceExtension
    {
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IPlanBuilder, BasicPlanBuilder>();
            services.AddScoped<IPlanBuilder, EnterprisePlanBuilder>();

            services.AddScoped<IPlanDirector, PlanDirector>();
        }
    }
}
