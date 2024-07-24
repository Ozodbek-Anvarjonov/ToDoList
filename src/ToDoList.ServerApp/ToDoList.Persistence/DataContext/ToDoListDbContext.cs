using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entities;

namespace ToDoList.Persistence.DataContext;

public class ToDoListDbContext : DbContext
{
    public DbSet<ToDoListEntity> ToDoLists => Set<ToDoListEntity>();

    public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ToDoListDbContext).Assembly);
    }
}