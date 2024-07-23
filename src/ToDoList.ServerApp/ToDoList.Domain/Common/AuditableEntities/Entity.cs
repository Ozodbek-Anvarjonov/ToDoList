namespace ToDoList.Domain.Common.AuditableEntities;

public class Entity : IEntity
{
    public Guid Id { get; set; }
}