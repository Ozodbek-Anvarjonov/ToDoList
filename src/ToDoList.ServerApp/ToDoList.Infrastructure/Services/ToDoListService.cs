using System.Linq.Expressions;
using ToDoList.Application.Services;
using ToDoList.Domain.Entities;
using ToDoList.Persistence.Repositories.Interfaces;

namespace ToDoList.Infrastructure.Services;

public class ToDoListService(IToDoListRepository toDoListRepository) : IToDoListService
{
    public IEnumerable<ToDoListEntity> Get(Expression<Func<ToDoListEntity, bool>>? predicate = null, bool asNoTracking = false) =>
        toDoListRepository.Get(predicate, asNoTracking);

    public ValueTask<IList<ToDoListEntity>> GetAllAsync(bool asNoTracking = false, CancellationToken cancellationToken = default) =>
        toDoListRepository.GetAllAsync(asNoTracking, cancellationToken);

    public ValueTask<ToDoListEntity> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default) =>
        toDoListRepository.GetByIdAsync(id, asNoTracking, cancellationToken);

    public ValueTask<IList<ToDoListEntity>> GetByIdsAsync(IList<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default) =>
        toDoListRepository.GetByIdsAsync(ids, asNoTracking, cancellationToken);

    public ValueTask<ToDoListEntity> CreateAsync(ToDoListEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default) =>
        toDoListRepository.CreateAsync(entity, saveChanges, cancellationToken);

    public ValueTask<ToDoListEntity> UpdateAsync(ToDoListEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default) =>
        toDoListRepository.UpdateAsync(entity, saveChanges, cancellationToken);

    public ValueTask<ToDoListEntity> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default) =>
        toDoListRepository.DeleteByIdAsync(id, saveChanges, cancellationToken);
}