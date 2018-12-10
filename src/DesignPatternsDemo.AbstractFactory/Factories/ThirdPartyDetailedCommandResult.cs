namespace DesignPatternsDemo.AbstractFactory.Factories
{
    public sealed class ThirdPartyDetailedCommandResult : ThirdPartyCommandResult
    {
        public ThirdPartyDetailedCommandResult(bool success, string message, object data) : base(success, message)
        {
            Dados = data;
        }

        public object Dados { get; }
    }
}
