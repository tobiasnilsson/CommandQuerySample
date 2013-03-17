using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandQuerySample.Core.NewCommands;
using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.Infrastructure.NewCommandHandlers
{
    public class NewAddUserToDepartmentsCommandHandler : ICommandHandler<NewAddUserToDepartmentsCommand>
    {
        private readonly ISampleDbContext _context;
        private readonly ICommandDispatcher _dispatcher;

        public NewAddUserToDepartmentsCommandHandler(ISampleDbContext context)
        {
            _context = context;
        }

        public void Handle(NewAddUserToDepartmentsCommand command)
        {
            foreach (var department in command.Departments)
            {
                department.Users.Add(command.User);
            }
        }
    }
}
