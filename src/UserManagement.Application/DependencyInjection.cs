using Microsoft.Extensions.DependencyInjection;

namespace UserManagement.Application;

public static class DependencyInjection 
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Add your application-specific services here
        // services.AddScoped<IUserService, UserService>();

        return services;
    }
}

