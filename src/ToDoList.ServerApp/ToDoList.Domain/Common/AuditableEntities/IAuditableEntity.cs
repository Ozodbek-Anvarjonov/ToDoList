namespace ToDoList.Domain.Common.AuditableEntities;

public interface IAuditableEntity : IEntity
{
    DateTimeOffset CreatedTime { get; set; }

    DateTimeOffset? UpdatedTime { get; set; }
}