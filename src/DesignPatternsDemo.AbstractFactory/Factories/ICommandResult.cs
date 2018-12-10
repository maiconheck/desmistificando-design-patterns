namespace DesignPatternsDemo.AbstractFactory.Factories
{
    // Abstract Product    
    public interface ICommandResult
    {
        bool Success { get; }

        string Message { get; }
    }
}