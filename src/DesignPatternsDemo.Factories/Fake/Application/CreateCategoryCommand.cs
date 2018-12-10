using System;

namespace DesignPatternsDemo.Factories.Fake.Application
{
    public class CreateCategoryCommand : ICommand
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}