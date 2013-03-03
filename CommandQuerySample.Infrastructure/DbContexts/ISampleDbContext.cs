using System.Data.Entity;
using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Infrastructure.DbContexts
{
    public interface ISampleDbContext
    {
        IDbSet<User> Users { get; set; }
        IDbSet<Department> Departments { get; set; }

        int SaveChanges();
    }
}