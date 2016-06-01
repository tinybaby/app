using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.Infrastructure.Data
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {       
        IQueryable<TEntity> Table { get; }
               
        IQueryable<TEntity> TableUntracked { get; }
       
        ICollection<TEntity> Local { get; }

        TEntity GetById(object id);

        TEntity Attach(TEntity entity);
        
        void Insert(TEntity entity);

        void InsertRange(IEnumerable<TEntity> entities, int batchSize = 100);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        bool IsModified(TEntity entity);

        IDictionary<string, object> GetModifiedProperties(TEntity entity);

        IDbContext Context { get; }
        
        bool? AutoCommitEnabled { get; set; }
    }
}
