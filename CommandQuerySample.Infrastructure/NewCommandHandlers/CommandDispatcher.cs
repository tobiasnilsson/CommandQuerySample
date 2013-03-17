using System;
using CommandQuerySample.Core.NewCommands;
using StructureMap;

namespace CommandQuerySample.Infrastructure.NewCommandHandlers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        public ICommandHandler GetHandler(ICommand command)
        {
            var commandType = command.GetType();

            Type handlerType = typeof(ICommandHandler<>);
            // MakeGenericType is badly named
            Type constructedClass = handlerType.MakeGenericType(commandType);

            //var handler = Activator.CreateInstance(constructedClass) as ICommandHandler<ICommand>;

            var handler = ObjectFactory.GetInstance(constructedClass);

            return handler as ICommandHandler;
        }

        public ICommandValidator GetValidator(ICommand command)
        {
            var commandType = command.GetType();

            Type validatorType = typeof(ICommandValidator<>);
            // MakeGenericType is badly named
            Type constructedClass = validatorType.MakeGenericType(commandType);

            //var handler = Activator.CreateInstance(constructedClass) as ICommandHandler<ICommand>;

            var validator = ObjectFactory.GetInstance(constructedClass);

            return validator as ICommandValidator; //ICommandValidator<ICommand>;
        }
    }
}