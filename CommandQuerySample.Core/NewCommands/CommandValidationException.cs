using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandQuerySample.Infrastructure.NewCommandHandlers
{
    public class CommandValidationException : Exception
    {
        private readonly IEnumerable<string> _errorMessages;

        public CommandValidationException(IEnumerable<string> errorMessages)
        {
            _errorMessages = errorMessages;
        }

        public override string Message
        {
            get
            {
                return string.Join(string.Empty, _errorMessages);
            }
        }
    }
}
