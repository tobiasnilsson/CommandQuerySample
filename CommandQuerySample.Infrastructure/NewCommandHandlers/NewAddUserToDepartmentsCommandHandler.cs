using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandQuerySample.Core.Entities;
using CommandQuerySample.Core.NewCommands;
using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.Infrastructure.NewCommandHandlers
{
    public class NewAddUserToDepartmentsCommandHandler : ICommandHandler<NewAddUserToDepartmentsCommand>
    {
        private readonly ISampleDbContext _context;

        public NewAddUserToDepartmentsCommandHandler(ISampleDbContext context)
        {
            _context = context;
        }

        public void Handle(object commandObj)
        {
            var command = (NewAddUserToDepartmentsCommand) commandObj;
            foreach (var department in command.Departments)
            {
                if(department.Users == null)
                    department.Users = new List<User>();

                department.Users.Add(command.User);

                if(department.Id == 0)
                    _context.Departments.Add(department);
            }
        }
    }
}
