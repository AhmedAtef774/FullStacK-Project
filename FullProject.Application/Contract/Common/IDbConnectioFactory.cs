using System.Data;
using Microsoft.Extensions.Configuration;

public interface IDbConnectionFactory {
    
    IDbConnection CreateConnection();
}