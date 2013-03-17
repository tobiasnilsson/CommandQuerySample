using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Core.NewCommands
{
    public interface ICommandValidator
    {
        ValidationResult Validate(object commandObj);
    }

    public interface ICommandValidator<TCommand> : ICommandValidator where TCommand : ICommand
    {
    }
}
