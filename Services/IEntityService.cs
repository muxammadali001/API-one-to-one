namespace TaxiDrivers.Services
{
    public interface IEntityService<TEntity> where TEntity : class
    {
        Task<(bool ISucces, Exception e)> InsertAsync(TEntity entity);
        Task<(bool ISucces, Exception e)> UpdateAsync(TEntity entity);
        Task <TEntity> GetByIdAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
        Task <(bool ISucces, Exception e)>DeleteAsync(Guid id);
    }
}
