using TaxiDrivers.Data;
using TaxiDrivers.Entities;

namespace TaxiDrivers.Services;

public class CarService : IEntityService<Car>
{
    private readonly ILogger<CarService> _logger;
    private readonly AppDbContext _context;

    public CarService(ILogger<CarService> logger, AppDbContext contex)
     {
        _logger = logger;
        _context = contex;
     }
    public Task<(bool ISucces, Exception e)> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Car> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<(bool ISucces, Exception e)> InsertAsync(Car entity)
    {
        try
        {
            await _context.Cars.AddAsync(entity);
            await _context.SaveChangesAsync();
            _logger.LogInformation($"New car is add database with {entity.id}");
            return (true, null);
        }
        catch (Exception e)
        {
            _logger.LogError("new car was not added. Exception: /n {e.Message}");
            return (false, e);
        }  
    }

    public Task<(bool ISucces, Exception e)> UpdateAsync(Car entity)
    {
        throw new NotImplementedException();
    }
}
