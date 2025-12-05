using Microsoft.EntityFrameworkCore;
using JobTrackerServer.Domain.Entities;

namespace JobTrackerServer.Infrastructure.Persistence;

public class JobDbContext : DbContext
{
    public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
    {
    }
    public DbSet<Job> Jobs { get; set; }
}