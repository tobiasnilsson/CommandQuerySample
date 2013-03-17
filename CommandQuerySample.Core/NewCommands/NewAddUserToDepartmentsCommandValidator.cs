using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Core.NewCommands
{
    public class NewAddUserToDepartmentsCommandValidator : ICommandValidator<NewAddUserToDepartmentsCommand>
    {
        public ValidationResult Validate(NewAddUserToDepartmentsCommand command)
        {
            var result = new ValidationResult();

            if (command.User == null)
            {
                result.IsValid = false;
                result.ErrorMessages.Add("Must contain user");
            }

            if (command.Departments == null || !command.Departments.Any())
            {
                result.IsValid = false;
                result.ErrorMessages.Add("Must contain departments");
            }

            return result;
        }

        public ValidationResult Validate(object command)
        {
            return Validate((NewAddUserToDepartmentsCommand) command);
        }
    }
}
