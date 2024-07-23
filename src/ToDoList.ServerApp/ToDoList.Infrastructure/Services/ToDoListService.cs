using System.Linq.Expressions;
using ToDoList.Application.Services;
using ToDoList.Domain.Entities;

namespace ToDoList.Infrastructure.Services;

public class ToDoListService : IToDoListService
{
    public IEnumerable<ToDoListEntity> Get(Expression<Func<ToDoListEntity, bool>>? predicate = null, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }

    public ValueTask<IList<ToDoListEntity>> GetAllAsync(bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ToDoListEntity> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<IList<ToDoListEntity>> GetByIdsAsync(IList<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    
    public ValueTask<ToDoListEntity> CreateAsync(ToDoListEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ToDoListEntity> UpdateAsync(ToDoListEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ToDoListEntity> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}