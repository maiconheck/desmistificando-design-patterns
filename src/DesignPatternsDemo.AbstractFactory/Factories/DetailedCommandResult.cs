namespace DesignPatternsDemo.AbstractFactory.Factories
{
    public sealed class DetailedCommandResult : CommandResult
    {
        public DetailedCommandResult(bool success, string message, object data) : base(success, message)
        {
            Data = data;
        }

        public object Data { get; }
    }    
}