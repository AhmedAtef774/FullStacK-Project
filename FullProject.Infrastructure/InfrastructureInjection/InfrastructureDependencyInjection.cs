using FullProject.Application.Contract.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


public static class InfrastructureDependencyInjection {
    
    public static IServiceCollection RegisterRepositories(this IServiceCollection services) {

       services.AddScoped(typeof(IRepository<,>),typeof(Repository<,>));

       services.AddScoped<ICategoryRepository,CategoryRepository>();

        return services;
    }

    public static IServiceCollection RegisterDbFactory(this IServiceCollection services , IConfiguration configuration){

        services.AddScoped<IDbConnectionFactory,SqlConnectionFactory>();

        return services;
    }
}