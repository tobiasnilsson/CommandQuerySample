using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandQuerySample.Core.Commands;
using CommandQuerySample.Core.Entities;
using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.Infrastructure.Commands
{
    public class AddUserToDepartmentsCommand : CommandBase, IAddUserToDepartmentsCommand
    {
        public AddUserToDepartmentsCommand(ISampleDbContext context) : base(context)
        {
        }

        public void Add(User user, IEnumerable<Department> departments)
        {
            throw new NotImplementedException();
        }
    }
}
