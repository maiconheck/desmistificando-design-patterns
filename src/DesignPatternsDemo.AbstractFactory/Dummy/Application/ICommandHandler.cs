using DesignPatternsDemo.AbstractFactory.Factories;

namespace DesignPatternsDemo.AbstractFactory.Dummy.Application
{
    public interface ICommandHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}