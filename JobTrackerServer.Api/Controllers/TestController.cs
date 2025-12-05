
using Microsoft.AspNetCore.Mvc;

namespace JobTrackerServer.Api.Controllers;

[ApiController]
[Route("api")]
public class TestController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Ping()
    {
        return Ok("pong1");
    }
}
