using Microsoft.AspNetCore.Mvc;
using TaxiDrivers.Services;

namespace TaxiDrivers.Controllers;

 public class CarController : ControllerBase
 {
    private readonly ILogger<CarController> _logger;
    private readonly CarService _service;

    public  CarController(ILogger<CarController> logger,CarService service)
    {
        _logger = logger;
        _service = service;
    }

}