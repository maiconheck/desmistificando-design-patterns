using System;
using Flunt.Notifications;

namespace DesignPatternsDemo.AbstractFactory.Dummy.Domain.Model
{
    public abstract class Entity : Notifiable
    {
        public Guid Id { get; }
    }
}