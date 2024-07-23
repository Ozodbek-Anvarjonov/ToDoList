using System.Linq.Expressions;
using ToDoList.Domain.Entities;

namespace ToDoList.Persistence.Repositories.Interfaces;

public interface IToDoListRepository
{
    IQueryable<ToDoListEntity> Get(Expression<Func<ToDoListEntity, bool>>? predicate = default, bool asNoTracking = false);

    ValueTask<IList<ToDoListEntity>> GetAllAsync(bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<ToDoListEntity> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<IList<ToDoListEntity>> GetByIdsAsync(IList<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<ToDoListEntity> CreateAsync(ToDoListEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<ToDoListEntity> UpdateAsync(ToDoListEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<ToDoListEntity> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default);
}