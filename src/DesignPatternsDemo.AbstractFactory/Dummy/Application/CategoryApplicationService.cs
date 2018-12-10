﻿using DesignPatternsDemo.AbstractFactory.Dummy.Domain.Model;
using DesignPatternsDemo.AbstractFactory.Factories;

namespace DesignPatternsDemo.AbstractFactory.Dummy.Application
{
    public class CategoryApplicationService : CategoryApplicationServiceBase,
        ICommandHandler<CreateCategoryCommand>,
        ICommandHandler<DeactivateCategoryCommand>
    {
        public CategoryApplicationService(ICommandResultFactory commandResultFactory)
            : base(commandResultFactory)
        {
        }

        public ICommandResult Handle(CreateCategoryCommand command)
        {
            //var category = AccountFactory.NewCategory(command);
            var category = new Category(command.Name, command.Description);

            return Create(category, new { category.Name, category.Active }, $"Categoria {category.Name} criada com sucesso.");
        }

        public ICommandResult Handle(DeactivateCategoryCommand command)
        {
            //var category = await _categoryRepository.GetByIdAsync(command.Id);
            var category = new Category("Alimentos", "Setor de alimentos e derivados");

            category.Deactivate();

            return Update(category, new { category.Name, category.Active }, $"Categoria {category?.Name} atualizada com sucesso.");
        }
    }
}