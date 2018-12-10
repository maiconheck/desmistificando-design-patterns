using System.Collections.Generic;
using Flunt.Notifications;

namespace DesignPatternsDemo.AbstractFactory.Factories
{
    // Concrete Factory CommandResult
    public class CommandResultFactory : ICommandResultFactory
    {
        public ICommandResult NewSuccessCommandResult(string message) => new CommandResult(true, message);

        public ICommandResult NewSuccessCommandResult(object data, string message) => new DetailedCommandResult(true, message, data);

        public ICommandResult NewFailCommandResult(string message) => new CommandResult(false, message);

        public ICommandResult NewFailCommandResult(
            IEnumerable<Notification> notifications,
            string message = "Por favor, corrija os erros abaixo:")
                => new DetailedCommandResult(false, message, notifications);
    }
}