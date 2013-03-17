using System.Data.Entity.ModelConfiguration;
using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Infrastructure.DbConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {

        }
    }
}