using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotnet7OnionArchitecture.Application.Interfaces.Repositories;
using Dotnet7OnionArchitecture.Domain.Common;

namespace Dotnet7OnionArchitecture.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IEntitiyBase, new();

        IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntitiyBase, new();

        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
