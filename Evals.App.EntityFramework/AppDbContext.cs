using Evals.App.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.EntityFramework
{
    public class AppDbContext : DbContext, IDbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions options) : base(options) { }


        #region IDbContext Methods

        public IQueryable<TEntity> Table<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            base.OnModelCreating(modelBuilder);
        }
    }
}
