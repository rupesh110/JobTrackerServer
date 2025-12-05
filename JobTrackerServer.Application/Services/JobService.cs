using JobTrackerServer.Application.Interfaces;
using JobTrackerServer.Domain.Entities;
using JobTrackerServer.Domain.Interfaces;

namespace JobTrackerServer.Application.Services;

public class JobService : IJobService
{
    private readonly IJobRepository _jobRepository;
    public JobService(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }
    public Task<IEnumerable<Job>> GetAllJobs()
    {
        return _jobRepository.GetAllJobs();
    }
}

