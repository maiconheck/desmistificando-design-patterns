using DesignPatternsDemo.AbstractFactory.Dummy.Domain.Model;

namespace DesignPatternsDemo.AbstractFactory.Factories
{
    // Factory Method
    public static class CommandResultFactory2
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