using InternshipRolePolicy.Application.Query.LoginQuery;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternshipRolePolicy.Application;

public static class ServiceCollection
{
    public static IServiceCollection AddApplication(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(typeof(LoginQueryHandler).Assembly);
        });
        return services;
    }
}
