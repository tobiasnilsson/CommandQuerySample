using System.Data.Entity;
using CommandQuerySample.Core.Entities;
using CommandQuerySample.Infrastructure.DbConfigurations;

namespace CommandQuerySample.Infrastructure.DbContexts
{
    public class SampleDbContext : DbContext, ISampleDbContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
        }
    }
}
