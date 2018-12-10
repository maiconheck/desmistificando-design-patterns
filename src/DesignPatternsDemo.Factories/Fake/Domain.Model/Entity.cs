using System;
using Flunt.Notifications;

namespace DesignPatternsDemo.Factories.Fake.Domain.Model
{
    public abstract class Entity : Notifiable
    {
        public Guid Id { get; }
    }
}