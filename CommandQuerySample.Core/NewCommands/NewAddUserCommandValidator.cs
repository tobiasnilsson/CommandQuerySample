using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Core.NewCommands
{
    public class NewAddUserCommandValidator : ICommandValidator<NewAddUserCommand>
    {
        public ValidationResult Validate(object commandObj)
        {
            var command = (NewAddUserCommand)commandObj;

            var result = new ValidationResult() { IsValid = true };

            if (command.User == null)
            {
                result.IsValid = false;
                result.ErrorMessages.Add("User must be set.");
                return result;
            }

            if (string.IsNullOrEmpty(command.User.Name))
            {
                result.IsValid = false;
                result.ErrorMessages.Add("Name must be set.");
            }

            if (command.User.Id > 0)
            {
                result.IsValid = false;
                result.ErrorMessages.Add("User id cannot be set.");
            }

            return result;
        }
    }

}
