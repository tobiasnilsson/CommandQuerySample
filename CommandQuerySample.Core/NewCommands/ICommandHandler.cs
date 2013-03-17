using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Core.NewCommands
{
    public interface ICommandHandler
    {
        void Handle(object commandObj);
    }

    public interface ICommandHandler<TCommand> : ICommandHandler where TCommand : ICommand
    {
    }
}
