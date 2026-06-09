using InternshipPractice.Infrastructure.Data;
using InternshipRolePolicy.Application.Interfaces;
using InternshipRolePolicy.Infrastructure.Options;
using InternshipRolePolicy.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternshipRolePolicy.Infrastructure;

public static class ServiceCollection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<InternshipPracticeDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        services.AddScoped<IUsersRepository, UsersRepository>();
        services.Configure<JwtOptions>(configuration.GetSection("JwtSettings"));
        services.AddScoped<IJwtService, JwtService>();

        return services;
    }
}
