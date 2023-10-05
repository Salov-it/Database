using Database.Application.Interface;
using Database.Application.PostgresDatabase;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Reflection;

namespace Database.Application
{
   public static class DependencyInjection
    {
       
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            Config config = new Config();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddScoped<IRepository,Repository>();
            services.AddSingleton<NpgsqlConnection>(new NpgsqlConnection(config.PostgresConnectionString));
            return services;
        }
    }
}
