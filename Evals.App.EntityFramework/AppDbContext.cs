using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions options) : base(options) { }



    }
}
