using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Evals.App.Infrastructure.Data
{
    public interface IDbContext
    {
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;

        void AddRange(IEnumerable<object> entities);

        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;

        void UpdateRange(IEnumerable<object> entities);

        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;

        void RemoveRange(IEnumerable<object> entities);

        IQueryable<TEntity> Table<TEntity>() where TEntity : class;

        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));


    }
}
