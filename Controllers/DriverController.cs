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

    public  DriverController(ILogger<DriverController> logger,CarService service)
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
            Model = newDriver.Model,
            Color = newDriver.Color,
            Number = newDriver.Number,
            Type = newDriver.Type
        };
        var result = await _service.InsertAsync(driver);
        var error = !result.ISucces;
        var message = result.e is null ?"Success" : result.e.Message;
        return Ok(new{error, message});
    }

}