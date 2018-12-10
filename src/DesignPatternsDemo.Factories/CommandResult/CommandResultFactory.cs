using DesignPatternsDemo.Factories.Fake.Domain.Model;

namespace DesignPatternsDemo.Factories.CommandResult
{
    // Factory Method
    public static class CommandResultFactory
    {
        public static ICommandResult NewCommandResult(
            ICommandResultFactory commandResultFactory,
            Entity entity,
            object successData = null,            
            string successMessage = "")
        {
            var commandResult = new ClientCommandResult(commandResultFactory);

            if (entity == null)
                return commandResult.NewFailCommandResult("Registro não encontrado.");

            if (entity.Invalid)
                return commandResult.NewFailCommandResult(entity.Notifications);

            return (successData == null)
                ? commandResult.NewSuccessCommandResult(successMessage)
                : commandResult.NewSuccessCommandResult(successData, successMessage);
        }
    }
}