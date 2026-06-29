using FullProject.Application.Contract.Repositories;
using FullProject.Domain.Entities;

public class Repository<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : BaseEntity<TKey> {



}