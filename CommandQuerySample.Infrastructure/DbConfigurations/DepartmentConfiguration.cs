using System.Data.Entity.ModelConfiguration;
using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Infrastructure.DbConfigurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            base.HasMany(d => d.Users);
        }
    }
}