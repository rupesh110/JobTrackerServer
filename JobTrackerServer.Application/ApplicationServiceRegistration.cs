using Microsoft.Extensions.DependencyInjection;
using JobTrackerServer.Application.Interfaces;
using JobTrackerServer.Application.Services;

namespace JobTrackerServer.Application;

public static class ApplicationServiceRegistration
{
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddScoped<IJobService, JobService>();
		return services;
	}
}