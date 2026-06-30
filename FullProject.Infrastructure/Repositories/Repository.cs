using FullProject.Application.Contract.Repositories;
using FullProject.Domain.Entities;

public class Repository<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : BaseEntity<TKey> {
 
   private readonly IDbConnectionFactory factory;

   public Repository(IDbConnectionFactory factory) {

      this.factory = factory;
   }

   public async Task<int> AddAsync(TEntity entity) {
      
   }

   public async Task<int> UpdateAsync(TEntity entity) {
     
   }

   public async Task<int> DeleteAsync(TEntity entity) {
    
   }

   public async Task<TEntity> GetAsync(TKey id) {
      
   }

   public async Task<IEnumerable<TEntity>> GetAllAsync() {
      
   }



   private string GetTableName() {

      var tablename = typeof(TEntity).Name;
      if(tablename.EndsWith("y")) {
         return tablename.Replace("y", "ies");
      }
      return tablename + "s";
   }

   private string GetColumnNames() {
      return string.Join(", ", typeof(TEntity).GetProperties().Select(p => p.Name != "Id"));
   }

   private string GetColumnNamesWithAt() {
      return string.Join(", ", typeof(TEntity).GetProperties().Select(p => "@" + p.Name != "Id"));
   }   




}