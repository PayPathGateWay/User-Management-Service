using Microsoft.Extensions.DependencyInjection;

namespace UserManagement.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Add your application-specific services here
        // services.AddScoped<IUserService, UserService>();

        return services;
    }
}

