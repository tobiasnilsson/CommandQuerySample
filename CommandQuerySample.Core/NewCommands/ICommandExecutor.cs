using System.Collections.Generic;

namespace CommandQuerySample.Core.NewCommands
{
    public interface ICommandExecutor
    {
        void Execute(IEnumerable<ICommand> commands);
    }
}