using Microsoft.Extensions.DependencyInjection;

namespace Database.Application
{
   public static class DependencyInjection
    {
        public static IServiceCollection AddUserServices(this IServiceCollection services)
        {
            
            //services.AddSingleton<IVkaApi, VKApi>();
           
            return services;
        }
    }
}
