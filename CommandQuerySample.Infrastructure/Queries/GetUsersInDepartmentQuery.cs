using System;
using System.Collections.Generic;
using System.Linq;
using CommandQuerySample.Core.Entities;
using CommandQuerySample.Core.Queries;
using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.Infrastructure.Queries
{
    public class GetUsersInDepartmentQuery : QueryBase, IGetUsersInDepartmentQuery
    {
        public GetUsersInDepartmentQuery(ISampleDbContext context)
            : base(context)
        {
        }

        public IEnumerable<User> GetUsers(int departmentId)
        {
            return Context.Users.Where(u => u.DepartmentId == departmentId);
        }
    }
}