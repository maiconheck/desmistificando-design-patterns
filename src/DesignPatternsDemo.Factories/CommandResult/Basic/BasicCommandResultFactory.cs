using System.Collections.Generic;
using Flunt.Notifications;

namespace DesignPatternsDemo.Factories.CommandResult.Basic
{
    // Concrete Factory BasicCommandResult
    public class BasicCommandResultFactory : ICommandResultFactory
    {
        public ICommandResult NewSuccessCommandResult(string message) => new BasicCommandResult(true, message);

        public ICommandResult NewSuccessCommandResult(object data, string message) => new BasicCommandResult(true, message);

        public ICommandResult NewFailCommandResult(string message) => new BasicCommandResult(false, message);

        public ICommandResult NewFailCommandResult(IEnumerable<Notification> notifications, string message = "Houve um erro na execução do comando.")
            => new BasicCommandResult(false, message);
    }
}