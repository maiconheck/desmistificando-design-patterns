using DesignPatternsDemo.AbstractFactory.Dummy.Domain.Model;
using System;

namespace DesignPatternsDemo.AbstractFactory.Dummy
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category GetById(Guid id) => new Category("Mobile", "Celulares e smartphones");
    }
}