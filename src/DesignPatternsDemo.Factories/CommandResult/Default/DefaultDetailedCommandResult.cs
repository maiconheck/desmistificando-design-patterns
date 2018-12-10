namespace DesignPatternsDemo.Factories.CommandResult.Default
{
    public sealed class DefaultDetailedCommandResult : DefaultCommandResult
    {
        public DefaultDetailedCommandResult(bool success, string message, object data) : base(success, message)
        {
            Data = data;
        }

        public object Data { get; }
    }    
}