using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotnet7OnionArchitecture.Application.Interfaces.Repositories;
using Dotnet7OnionArchitecture.Application.Interfaces.UnitOfWorks;
using Dotnet7OnionArchitecture.Persistence.Context;
using Dotnet7OnionArchitecture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Dotnet7OnionArchitecture.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;
        
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();


        public int SaveChanges() => dbContext.SaveChanges();


        public async Task<int> SaveChangesAsync() => await dbContext.SaveChangesAsync();
        

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext);


        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);
        
    }
}
