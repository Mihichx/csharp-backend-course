using Microsoft.AspNetCore.Mvc;

namespace StudentsApiWithModel.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnergyDrinksController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World!");
    }
    
}