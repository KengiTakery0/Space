using Microsoft.AspNetCore.Authorization;
using Space.Backend.Services.AutorizationService;

namespace Space.Backend.Models
{
    public static class Extensions
    {
        public static IServiceCollection AddAutorizationService(this IServiceCollection services) 
        {
            services.AddScoped<AutorizationService>();
            return services;
        }
    }
}
