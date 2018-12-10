using System;

namespace DesignPatternsDemo.AbstractFactory.Dummy.Application
{
    public class DeactivateCategoryCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}