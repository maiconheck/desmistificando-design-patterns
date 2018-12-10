namespace DesignPatternsDemo.Factories.CommandResult
{
    // Abstract Product    
    public interface ICommandResult
    {
        bool Success { get; }

        string Message { get; }
    }
}