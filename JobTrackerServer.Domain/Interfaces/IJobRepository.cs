using JobTrackerServer.Domain.Entities;

namespace JobTrackerServer.Domain.Interfaces;

public interface IJobRepository
{
    Task<IEnumerable<Job>> GetAllJobs();
}