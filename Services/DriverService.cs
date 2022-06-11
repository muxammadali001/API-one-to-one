using System.Runtime.CompilerServices;
using System.Data.SqlTypes;
using TaxiDrivers.Entities;
using TaxiDrivers.Data;

namespace TaxiDrivers.Services;

public class DriverService : IEntityService<Driver>
{
    private readonly ILogger<DriverService> _logger;
    private readonly AppDbContext _context;
    public DriverService(ILogger <DriverService> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public Task<List<Driver>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Driver> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
    Task<(bool ISucces, Exception e)> IEntityService<Driver>.DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    async Task<(bool ISucces, Exception e)> IEntityService<Driver>.InsertAsync(Driver entity)
    {
        try
        {
            await _context.Drivers.AddAsync(entity);
            await _context.SaveChangesAsync();
            _logger.LogInformation($"New Driver is add database with {entity.id}");
            return (true, null);
        }
        catch (Exception e)
        {
            _logger.LogError("new driver was not added. Exception: /n {e.Message}");
            return (false, e);
        }  
    }

    Task<(bool ISucces, Exception e)> IEntityService<Driver>.UpdateAsync(Driver entity)
    {
        throw new NotImplementedException();
    }
}
