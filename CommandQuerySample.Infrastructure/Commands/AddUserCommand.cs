using CommandQuerySample.Core.Commands;
using CommandQuerySample.Core.Entities;
using CommandQuerySample.Infrastructure.DbContexts;

namespace CommandQuerySample.Infrastructure.Commands
{
    public class AddUserCommand : CommandBase, IAddUserCommand
    {
        public AddUserCommand(ISampleDbContext context) : base(context)
        {
        }

        public void Add(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
        }
    }
}
