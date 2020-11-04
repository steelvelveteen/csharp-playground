using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace csharp_playground
{
    public class Database : IDatabase
    {
        public async Task<IEnumerable<T>> QueryAsync<T>(string sql) where T : class
        {
             using (var connection = OpenConnection())
            {
                return await connection.QueryAsync<T>(sql);
            }
        }

        private IDbConnection OpenConnection()
        {
            var connection = new NpgsqlConnection("Server=localhost;Database=test;Port=5432;User Id=sentinel;Password=M311am0J03yPostgresql;Integrated Security=true;Pooling=true");
            return connection;
        }
    }
}