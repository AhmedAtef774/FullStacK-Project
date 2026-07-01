using FullProject.Domain.Entities;

namespace FullProject.Application.Contract.Repositories;

public interface IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey> {

    Task<int> AddAsync(TEntity entity);

    Task<int> UpdateAsync(TEntity entity);

    Task<int> DeleteAsync(TKey id);

    Task<TEntity> GetAsync(TKey id);

    Task<IEnumerable<TEntity>> GetAllAsync();

}