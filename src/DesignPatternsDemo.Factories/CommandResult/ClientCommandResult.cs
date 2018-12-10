using Flunt.Notifications;
using System.Collections.Generic;

namespace DesignPatternsDemo.Factories.CommandResult
{    
    public sealed class ClientCommandResult
    {
        private readonly ICommandResultFactory _factory;

        public ClientCommandResult(ICommandResultFactory factory)
        {
            _factory = factory;
        }

        public ICommandResult NewSuccessCommandResult(string message = "")
            => _factory.NewSuccessCommandResult(message);

        public ICommandResult NewSuccessCommandResult(object data, string message = "")
            => _factory.NewSuccessCommandResult(data, message);

        public ICommandResult NewFailCommandResult(string message = "")
            => _factory.NewFailCommandResult(message);

        public ICommandResult NewFailCommandResult(IEnumerable<Notification> notifications, string message = "")
            => _factory.NewFailCommandResult(notifications, message);
    }
}