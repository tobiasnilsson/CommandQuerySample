using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.Infrastructure.Queries
{
    public abstract class QueryBase
    {
        protected readonly ISampleDbContext Context;

        protected QueryBase(ISampleDbContext context)
        {
            Context = context;
        }
    }
}
