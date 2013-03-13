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
    public class AddDepartmentCommand : CommandBase, IAddDepartmentCommand
    {
        public AddDepartmentCommand(ISampleDbContext context) : base(context)
        {
        }

        public void Add(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
