using DesignPatternsDemo.Factories.Fake.Domain.Model;
using DesignPatternsDemo.Factories.CommandResult;

namespace DesignPatternsDemo.Factories.Fake.Application
{
    public abstract class CategoryApplicationServiceBase
    {
        private readonly ICommandResultFactory _commandResultFactory;

        protected CategoryApplicationServiceBase(ICommandResultFactory commandResultFactory)
        {
            _commandResultFactory = commandResultFactory;
        }

        protected ICommandResult Create(Entity entity, object successData, string successMessage = "")
        {
            var result = CommandResultFactory.NewCommandResult(_commandResultFactory, entity, successData, successMessage);            

            if (!result.Success)
                return result;

            //await _repository.CreateAsync(entity);
            //_unitOfWork.Commit();

            return result;
        }

        protected ICommandResult Update(Entity entity, object successData, string successMessage = "")
        {
            var commandResult = new ClientCommandResult(_commandResultFactory);

            if (entity == null)
                return commandResult.NewFailCommandResult("Registro não encontrado.");

            var result = CommandResultFactory.NewCommandResult(_commandResultFactory, entity, successData, successMessage);

            if (!result.Success)
                return result;

            //await _repository.UpdateAsync(entity);
            //_unitOfWork.Commit();

            return result;
        }
    }
}