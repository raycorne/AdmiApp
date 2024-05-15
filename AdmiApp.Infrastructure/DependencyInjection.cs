using AdmiApp.Appl.Interfaces;
using AdmiApp.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AdmiApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IUniversityService, UniversityService>();

            return services;
        }
    }
}
