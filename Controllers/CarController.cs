using Microsoft.AspNetCore.Mvc;
using TaxiDrivers.Entities;
using TaxiDrivers.Models;
using TaxiDrivers.Services;

namespace TaxiDrivers.Controllers;
[ApiController]
[Route("api/[controller]")]

 public class CarController : ControllerBase
 {
    private readonly ILogger<CarController> _logger;
    private readonly CarService _service;

    public  CarController(ILogger<CarController> logger,CarService service)
    {
        _logger = logger;
        _service = service;
    }
    [HttpPost("/addcar")]
    public async Task<IActionResult> AddCar([FromForm]NewCar newCar)
    {
        var car = new Car()
        {
            id = Guid.NewGuid(),
            Model = newCar.Model,
            Color = newCar.Color,
            Number = newCar.Number,
            Type = newCar.Type
        };
        var result = await _service.InsertAsync(car);
        var error = !result.ISucces;
        var message = result.e is null ?"Success" : result.e.Message;
        return Ok(new{error, message});
    }

}