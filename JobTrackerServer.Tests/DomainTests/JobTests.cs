using Xunit;
using JobTrackerServer.Domain.Entities;

namespace JobTrackerServer.Tests.DomainTests;

public class JobTests
{
    [Fact]
    public void Job_Creation_Should_Set_Properties_Correctly()
    {
        // Arrange
        var jobId = 1;
        var jobTitle = "Software Engineer";
        var jobCompany = "Tech Corp";

        // Act
        var job = new Job
        {
            Id = jobId,
            Title = jobTitle,
            Company = jobCompany
        };
        // Assert
        Assert.Equal(jobId, job.Id);
        Assert.Equal(jobTitle, job.Title);
        Assert.Equal(jobCompany, job.Company);
    }

    [Fact]
    public void Job_Default_Values_Should_Be_Null() 
    {
        var job = new Job();

        Assert.Equal(0, job.Id);
        Assert.Null(job.Title);
        Assert.Null(job.Company);
    }
}