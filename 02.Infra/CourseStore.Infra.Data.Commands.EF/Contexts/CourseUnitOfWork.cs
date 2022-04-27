using CourseStore.Common.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Commands.EF.Contexts
{
    public class CourseUnitOfWork : IUnitOfWork
    {
        private readonly CourseStoreDbContext _context;

        public CourseUnitOfWork(CourseStoreDbContext context)
        {
            this._context = context;
        }

        public IDisposable BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            throw new NotImplementedException();
        }

        public Task<IDisposable> BeginTransactionAsync(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
