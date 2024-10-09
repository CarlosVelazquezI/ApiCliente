using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClashToday.CommonServices.PinValidator.Business.Contracts.Persistence;
using ClashToday.CommonServices.PinValidator.Infrastructure.Persistence;
using ClashToday.CommonServices.PinValidator.Infrastructure.Repositories;

namespace ClashToday.CommonServices.PinValidator.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ContextDb>(options =>
            options.UseNpgsql(configuration.GetConnectionString("ContextDb")));

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
