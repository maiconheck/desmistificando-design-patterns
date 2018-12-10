namespace DesignPatternsDemo.AbstractFactory.Factories
{    
    // Concrete Product CommandResult
    public class CommandResult : ICommandResult
    {
        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; }

        public string Message { get; }  
    }    
}