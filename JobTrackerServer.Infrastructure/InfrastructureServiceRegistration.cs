using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using JobTrackerServer.Infrastructure.Persistence;
using JobTrackerServer.Domain.Interfaces;
using JobTrackerServer.Infrastructure.Repositories;


namespace JobTrackerServer.Infrastructure;

public static class InfrastructureServiceRegistration
{
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString)
	{

        services.AddDbContext<JobDbContext>(options =>
    options.UseSqlServer(connectionString));
       //services.AddScoped<IJobRepository, InMemoryJobRepository>();
	   services.AddScoped<IJobRepository, EfJobRepository>();

        return services;
	}
}

