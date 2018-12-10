using Flunt.Validations;

namespace DesignPatternsDemo.Factories.Fake.Domain.Model
{
    public class Category : Entity
    {
        public Category(string name, string description = "")
        {
            Name = name;
            Description = description;
            Activate();

            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotNullOrEmpty(Name, nameof(Name), "Informe a categoria.")
                    .HasMaxLen(Name, 50, nameof(Name), "A categoria deve ter no máximo 50 caracteres.")
                    .HasMaxLen(Description, 100, nameof(Description), "A categoria deve ter no máximo 100 caracteres."));
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public bool Active { get; private set; }        

        public void Update(string name, string description = "")
        {
            Name = name;
            Description = description;
        }

        public void Activate() => Active = true;

        public void Deactivate() => Active = false;
    }
}