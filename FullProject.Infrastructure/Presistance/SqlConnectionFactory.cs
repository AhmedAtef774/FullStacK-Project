using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

public class SqlConnectionFactory : IDbConnectionFactory {
    
    private readonly IConfiguration _configuration;

    private readonly string connectionstring;

    public SqlConnectionFactory(IConfiguration configuration) 
    {
        _configuration = configuration;

       connectionstring =  _configuration.GetConnectionString("SqlConnection") ??throw new ArgumentNullException("Default");
    }
    public IDbConnection CreateConnection() {
        return new SqlConnection(connectionstring);
    }
}