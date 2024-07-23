namespace ToDoList.Domain.Common.AuditableEntities;

public class AudiTableEntity : Entity, IAuditableEntity
{
    public DateTimeOffset CreatedTime { get; set; }
    
    public DateTimeOffset? UpdatedTime { get; set; }
}