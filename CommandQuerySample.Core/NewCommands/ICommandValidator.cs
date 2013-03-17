using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Core.NewCommands
{
    public interface ICommandValidator<in TCommand> where TCommand : ICommand
    {
        ValidationResult Validate(TCommand command);
    }
}
