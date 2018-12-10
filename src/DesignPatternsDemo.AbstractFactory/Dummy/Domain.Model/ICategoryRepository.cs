using System;

namespace DesignPatternsDemo.AbstractFactory.Dummy.Domain.Model
{
    public interface ICategoryRepository
    {
        Category GetById(Guid id);
    }
}