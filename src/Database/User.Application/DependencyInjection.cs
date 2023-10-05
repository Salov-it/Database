using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using User.Application.CQRS.Command;

namespace User.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUserServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            //services.AddSingleton<IVkaApi, VKApi>();
            services.AddScoped<AddCommand>();
            services.AddScoped<AddHandler>();


            return services;
        }
    }
}
