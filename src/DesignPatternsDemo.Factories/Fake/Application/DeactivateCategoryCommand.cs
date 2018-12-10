using System;

namespace DesignPatternsDemo.Factories.Fake.Application
{
    public class DeactivateCategoryCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}