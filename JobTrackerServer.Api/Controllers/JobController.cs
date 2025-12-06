using Microsoft.AspNetCore.Mvc;
using JobTrackerServer.Application.Interfaces;

namespace JobTrackerServer.Api.Controllers;

[ApiController]
[Route("api/jobs")]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }


    [HttpGet("allJobs")]
    public async Task<IActionResult> GetAllJobs()
    {   
        var jobs = await _jobService.GetAllJobs();
        return Ok(jobs);
    }

    [HttpPost("addJob")]
    public async Task<IActionResult> AddJob()
    {
        await Task.CompletedTask;
        return StatusCode(201, "received12");
    }
}