﻿using System.Collections.Generic;
using Flunt.Notifications;

namespace DesignPatternsDemo.Factories.CommandResult.Default
{
    // Concrete Factory DefaultCommandResult
    public class DefaultCommandResultFactory : ICommandResultFactory
    {
        public ICommandResult NewSuccessCommandResult(string message) => new DefaultCommandResult(true, message);

        public ICommandResult NewSuccessCommandResult(object data, string message) => new DefaultDetailedCommandResult(true, message, data);

        public ICommandResult NewFailCommandResult(string message) => new DefaultCommandResult(false, message);

        public ICommandResult NewFailCommandResult(
            IEnumerable<Notification> notifications,
            string message = "Por favor, corrija os erros abaixo:")
                => new DefaultDetailedCommandResult(false, message, notifications);
    }
}