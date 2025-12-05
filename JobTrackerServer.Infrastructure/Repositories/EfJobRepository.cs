using Microsoft.EntityFrameworkCore;
using JobTrackerServer.Domain.Entities;
using JobTrackerServer.Domain.Interfaces;
using JobTrackerServer.Infrastructure.Persistence;

namespace JobTrackerServer.Infrastructure.Repositories;

public class EfJobRepository : IJobRepository
{
    private readonly JobDbContext _context;

    public EfJobRepository(JobDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Job>> GetAllJobs()
    {
        return await _context.Jobs.ToListAsync();
    }
}
