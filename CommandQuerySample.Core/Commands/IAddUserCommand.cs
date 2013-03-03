using CommandQuerySample.Core.Entities;

namespace CommandQuerySample.Core.Commands
{
    public interface IAddUserCommand
    {
        void Add(User user);
    }
}