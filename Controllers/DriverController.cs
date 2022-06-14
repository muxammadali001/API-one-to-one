using Microsoft.AspNetCore.Mvc;
using TaxiDrivers.Entities;
using TaxiDrivers.Models;
using TaxiDrivers.Services;

namespace TaxiDrivers.Controllers;
[ApiController]
[Route("api/[controller]")]

 public class DriverController : ControllerBase
 {
    private readonly ILogger<DriverController> _logger;
    private readonly DriverService _service;

    public  DriverController(ILogger<DriverController> logger,DriverService service)
    {
        _logger = logger;
        _service = service;
    }
    [HttpPost("/adddriver")]
    public async Task<IActionResult> Adddriver([FromForm]NewDriver newDriver)
    {
        var driver = new Driver()
        {
            id = Guid.NewGuid(),
            FirstName = newDriver.FirstName,
            LastName = newDriver.LastName,
            PhoneNumber = newDriver.PhoneNumber,
            Age = newDriver.Age
        };
        var result = await _service.InsertAsync(driver);
        var error = !result.IsSuccess;
        var message = result.e is null ?"Success" : result.e.Message;
        return Ok(new{error, message});
    }
    [HttpGet("/getdrivers")]
    public async Task<IActionResult> GetDrivers([FromQuery]Guid id)
    {
        var drivers = await _service.GetByIdAsync(id);
        return Ok(drivers);
    }

}