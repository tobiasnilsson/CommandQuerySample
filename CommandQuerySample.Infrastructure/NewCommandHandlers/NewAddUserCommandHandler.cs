using CommandQuerySample.Core.NewCommands;
using CommandQuerySample.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Infrastructure.NewCommandHandlers
{
    public class NewAddUserCommandHandler : ICommandHandler<NewAddUserCommand>
    {
        private readonly ISampleDbContext _context;

        public NewAddUserCommandHandler(ISampleDbContext context)
        {
            _context = context;
        }

        public void Handle(object commandObj)
        {
            var command = (NewAddUserCommand)commandObj;
            _context.Users.Add(command.User); 
        }
    }
}
