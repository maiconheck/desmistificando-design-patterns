using System;

namespace DesignPatternsDemo.AbstractFactory.Dummy.Application
{
    public class CreateCategoryCommand : ICommand
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}