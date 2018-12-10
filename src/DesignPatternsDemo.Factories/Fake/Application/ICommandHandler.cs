using DesignPatternsDemo.Factories.CommandResult;

namespace DesignPatternsDemo.Factories.Fake.Application
{
    public interface ICommandHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}