using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandQuerySample.Core.NewCommands
{
    public class NewAddUserToDepartmentsCommandValidator : ICommandValidator<NewAddUserToDepartmentsCommand>
    {
        public ValidationResult Validate(object commandObj)
        {
            var command = (NewAddUserToDepartmentsCommand) commandObj;

            var result = new ValidationResult { IsValid = true };

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
    }
}
