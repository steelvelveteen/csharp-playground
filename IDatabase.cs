using System.Collections.Generic;
using System.Threading.Tasks;

namespace csharp_playground
{
    public interface IDatabase
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sql) where T : class; 
    }
}