using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WaterBar.Infrastructure.Time;
using WaterBar.SharedKernel;

namespace WaterBar.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddServices();



        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}
