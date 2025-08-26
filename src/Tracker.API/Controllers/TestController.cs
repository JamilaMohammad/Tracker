using Microsoft.AspNetCore.Mvc;

namespace Tracker.API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello");
    }
    
}