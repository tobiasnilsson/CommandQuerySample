using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.Infrastructure.Commands
{
    public abstract class CommandBase
    {
        protected readonly ISampleDbContext Context;

        protected CommandBase(ISampleDbContext context)
        {
            Context = context;
        }
    }
}
