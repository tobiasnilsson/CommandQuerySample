using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandQuerySample.Core.NewCommands
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public IList<string> ErrorMessages { get; set; }
    }
}
