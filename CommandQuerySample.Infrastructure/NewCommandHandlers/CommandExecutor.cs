using CommandQuerySample.Core.Commands;
using CommandQuerySample.Core.NewCommands;
using CommandQuerySample.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Infrastructure.NewCommandHandlers
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly ISampleDbContext _context;
        private readonly ICommandDispatcher _dispatcher;

        public CommandExecutor(ISampleDbContext context, ICommandDispatcher dispatcher)
        {
            _context = context;
            _dispatcher = dispatcher;
        }

        public void Execute(IEnumerable<ICommand> commands)
        {
            foreach (var command in commands)
            {
                var commandType = command.GetType();

                var validator = _dispatcher.GetValidator<commandType>();
                var validationResult = validator.Validate(command);

                if (!validationResult.IsValid)
                    throw new CommandValidationException(validationResult.ErrorMessages);

                var handler = _dispatcher.GetHandler<commandType>();
                handler.Handle(command);
            }

            _context.SaveChanges();
        }
    }
}
