using EduraTask.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EduraTask.Application
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(conf =>
            {
                conf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddInfrastructure(configuration);

            return services;
        }
    }
}
