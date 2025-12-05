using JobTrackerServer.Domain.Entities;

namespace JobTrackerServer.Application.Interfaces;

public interface IJobService
{
    Task<IEnumerable<Job>> GetAllJobs();
}