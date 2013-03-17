using System;
using CommandQuerySample.Core.NewCommands;
using StructureMap;
using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.Infrastructure.NewCommandHandlers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        public ICommandHandler GetHandler(ICommand command)
        {
            var commandType = command.GetType();

            Type handlerType = typeof(ICommandHandler<>);
            Type constructedClass = handlerType.MakeGenericType(commandType);

            var handler = ObjectFactory.GetInstance(constructedClass);

            return handler as ICommandHandler;
        }

        public ICommandValidator GetValidator(ICommand command)
        {
            var commandType = command.GetType();

            Type validatorType = typeof(ICommandValidator<>);
            Type constructedClass = validatorType.MakeGenericType(commandType);

            var validator = ObjectFactory.GetInstance(constructedClass);

            return validator as ICommandValidator;
        }
    }
}