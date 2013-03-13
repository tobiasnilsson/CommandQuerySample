using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Core.Commands
{
    public interface IAddUserToDepartmentsCommand
    {
        void Add(User user, IEnumerable<Department> departments);
    }
}
