namespace DesignPatternsDemo.Factories.CommandResult.Basic
{    
    // Concrete Product BasicCommandResult
    public class BasicCommandResult : ICommandResult
    {
        public BasicCommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; }

        public string Message { get; }  
    }    
}