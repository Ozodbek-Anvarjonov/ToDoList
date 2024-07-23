namespace ToDoList.Domain.Common.AuditableEntities;

public interface IEntity
{
    Guid Id { get; set; }
}