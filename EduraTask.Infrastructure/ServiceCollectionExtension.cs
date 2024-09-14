using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EduraTask.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EduraContext>(x => x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IBookingRepository, BookingRepository>();
        services.AddScoped<IBookingServiceRepository, BookingServiceRepository>();
        services.AddScoped<IBranchRepository, BranchRepository>();
        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddScoped<ITransactionRepository, TransactionRepository>();

        return services;
    }
}
