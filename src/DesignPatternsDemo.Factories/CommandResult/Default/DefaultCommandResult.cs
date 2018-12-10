namespace DesignPatternsDemo.Factories.CommandResult.Default
{    
    // Concrete Product DefaultCommandResult
    public class DefaultCommandResult : ICommandResult
    {
        public DefaultCommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; }

        public string Message { get; }  
    }    
}