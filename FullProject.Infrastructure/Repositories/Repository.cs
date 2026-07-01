using Dapper;
using FullProject.Application.Contract.Repositories;
using FullProject.Domain.Entities;

public class Repository<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : BaseEntity<TKey> {
 
   private readonly IDbConnectionFactory factory;

   public Repository(IDbConnectionFactory factory) {

      this.factory = factory;
   }

   public async Task<int> AddAsync(TEntity entity) {
      
      using var connection = factory.CreateConnection();

      connection.Open();

      var sql = @$"INSERT INTO {GetTableName()} ({GetColumnNames()}) VALUES({GetColumnNamesWithAt()})
                    SELECT CAST(SCOPE_IDENTITY() AS INT)";

      var result = await connection.ExecuteScalarAsync<int>(sql, new {entity});

      return result;
   }

   public async Task<int> UpdateAsync(TEntity entity) {
     using var connection = factory.CreateConnection();

     connection.Open();

     var sql = @$"UPDATE {GetTableName()} SET {GetColumnNamesWithAt()} where Id = @Id";

     var result = await connection.ExecuteAsync(sql, new {entity});

     return result;
   }

   public async Task<int> DeleteAsync(TKey id) {
     using var connection = factory.CreateConnection();

     connection.Open();

     var sql = @$"DELETE FROM {GetTableName()} where Id = @Id";

     var result = await connection.ExecuteAsync(sql, new {Id = id});

     return result;
   }

   public async Task<TEntity> GetAsync(TKey id) {

      using var connection = factory.CreateConnection();

      connection.Open();

      var sql = @$"SELECT * from {GetColumnNames} where Id = @Id";

      var result = await connection.QueryFirstOrDefaultAsync<TEntity>(sql, new { Id = id});

      return result!;
   }

   public async Task<IEnumerable<TEntity>> GetAllAsync() {
      using var connection = factory.CreateConnection();

      connection.Open();

      var sql = $"SELECT * FROM {GetTableName()}";

      var result = await connection.QueryAsync<TEntity>(sql);

      return result;
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