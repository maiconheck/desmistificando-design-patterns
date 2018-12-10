using DesignPatternsDemo.AbstractFactory.Dummy.Domain.Model;
using DesignPatternsDemo.AbstractFactory.Factories;

namespace DesignPatternsDemo.AbstractFactory.Dummy.Application
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
            var result = CommandResultFactory2.NewCommandResult(_commandResultFactory, entity, successData, successMessage);            

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

            var result = CommandResultFactory2.NewCommandResult(_commandResultFactory, entity, successData, successMessage);

            if (!result.Success)
                return result;

            //await _repository.UpdateAsync(entity);
            //_unitOfWork.Commit();

            return result;
        }
    }
}