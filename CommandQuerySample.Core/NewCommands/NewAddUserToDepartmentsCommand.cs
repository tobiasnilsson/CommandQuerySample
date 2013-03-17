using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Core.NewCommands
{
    public class NewAddUserToDepartmentsCommand : ICommand
    {
        public User User { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
