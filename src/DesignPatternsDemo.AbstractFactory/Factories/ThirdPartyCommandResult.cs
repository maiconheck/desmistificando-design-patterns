using Newtonsoft.Json;

namespace DesignPatternsDemo.AbstractFactory.Factories
{
    // Concrete Product ThirdParty
    public class ThirdPartyCommandResult : ICommandResult
    {
        public ThirdPartyCommandResult(bool success, string message)
        {
            Codigo = success ? 0 : 1;
            Message = message;
        }

        public int Codigo { get; }

        [JsonProperty("mensagem")]
        public string Message { get; }

        [JsonIgnore]
        public bool Success => Codigo == 0 ? true : false;

    }
}
