using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace CommandQuerySample.Core.NewCommands
{
    public interface ICommandDispatcher
    {
        ICommandHandler<ICommand> GetHandler<TCommand>() where TCommand : ICommand;
        ICommandValidator<ICommand> GetValidator<TCommand>() where TCommand : ICommand;
    }

    public class CommandDispatcher : ICommandDispatcher
    {
        public ICommandHandler<ICommand> GetHandler<TCommand>() where TCommand : ICommand
        {
            var handler = ObjectFactory.GetInstance<ICommandHandler<TCommand>>();

            return handler as ICommandHandler<ICommand>;
        }

        public ICommandValidator<ICommand> GetValidator<TCommand>() where TCommand : ICommand
        {
            var handler = ObjectFactory.GetInstance<ICommandValidator<TCommand>>();

            return handler as ICommandValidator<ICommand>;
        }
    }
}
