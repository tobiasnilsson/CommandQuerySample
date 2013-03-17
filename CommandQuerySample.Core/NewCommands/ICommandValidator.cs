using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Core.NewCommands
{
    public interface ICommandValidator
    {
        ValidationResult Validate(object command);
    }

    public interface ICommandValidator<in TCommand> : ICommandValidator where TCommand : ICommand
    {
        //ValidationResult Validate(TCommand command);
    }
}
