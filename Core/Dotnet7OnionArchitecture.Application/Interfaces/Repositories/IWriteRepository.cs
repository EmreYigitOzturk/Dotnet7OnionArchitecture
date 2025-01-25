using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotnet7OnionArchitecture.Domain.Common;

namespace Dotnet7OnionArchitecture.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class , IEntitiyBase, new()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task HardDeleteAsync(T entity);

    }
}
