namespace ToDoList.Api.Models.Dtos;

public class ToDoListDto
{
    public Guid Id { get; set; }

    public string Title { get; set; } = default!;

    public bool IsDone { get; set; }

    public bool IsFavorite { get; set; }

    public DateTimeOffset DueTime { get; set; }

    public DateTimeOffset Remidertime { get; set; }
}