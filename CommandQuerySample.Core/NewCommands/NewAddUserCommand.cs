using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Core.NewCommands
{
    public class NewAddUserCommand : ICommand
    {
        public User User { get; set; }
    }
}
