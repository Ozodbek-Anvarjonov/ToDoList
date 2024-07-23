using ToDoList.Domain.Common.AuditableEntities;

namespace ToDoList.Domain.Entities;

public class ToDoListEntity : AudiTableEntity
{
    public string Title { get; set; } = default!;

    public bool IsDone { get; set; }

    public bool IsFavorite { get; set; }

    public DateTimeOffset DueTime { get; set; }

    public DateTimeOffset Remidertime { get; set; }
}