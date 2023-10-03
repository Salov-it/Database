using Database.Application.Interface;
using Database.Application.PostgresDatabase;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Database.Application
{
   public static class DependencyInjection
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {

            //services.AddSingleton<IVkaApi, VKApi>();
            services.AddScoped<IRepository, Repository>();
            services.AddSingleton<NpgsqlConnection>(new NpgsqlConnection(Config.PostgresConnectionString));


            return services;
        }
    }
}
