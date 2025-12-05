using JobTrackerServer.Domain.Entities;
using JobTrackerServer.Domain.Interfaces;

namespace JobTrackerServer.Infrastructure.Repositories;


public class InMemoryJobRepository : IJobRepository
{
    private readonly List<Job> _jobs = new()
    {
        new Job { Id = 1, Title = "Software Engineer", Company = "Tech Corp" },
        new Job { Id = 2, Title = "Data Analyst", Company = "Data Inc" },
        new Job { Id = 3, Title = "Product Manager", Company = "Business Solutions" }
    };

    public Task<IEnumerable<Job>> GetAllJobs()
    {
        return Task.FromResult<IEnumerable<Job>>(_jobs);
    }
}
