using System.Collections.Generic;
using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Core.Queries
{
    public interface IGetUsersInDepartmentQuery
    {
        IEnumerable<User> GetUsers(int departmentId);
    }
}