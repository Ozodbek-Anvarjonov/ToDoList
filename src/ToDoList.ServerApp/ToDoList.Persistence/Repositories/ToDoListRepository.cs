using System.Linq.Expressions;
using ToDoList.Domain.Entities;
using ToDoList.Persistence.DataContext;
using ToDoList.Persistence.Repositories.Interfaces;

namespace ToDoList.Persistence.Repositories;

public class ToDoListRepository : EntityRepositoryBase<ToDoListEntity, ToDoListDbContext>, IToDoListRepository
{
    public ToDoListRepository(ToDoListDbContext context) : base(context) { }

    public new IQueryable<ToDoListEntity> Get(Expression<Func<ToDoListEntity, bool>>? predicate = null, bool asNoTracking = false) =>
        base.Get(predicate, asNoTracking);

    public new ValueTask<IList<ToDoListEntity>> GetAllAsync(bool asNoTracking = false, CancellationToken cancellationToken = default) =>
        base.GetAllAsync(asNoTracking, cancellationToken);

    public new ValueTask<ToDoListEntity> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default) =>
        base.GetByIdAsync(id, asNoTracking, cancellationToken)!;

    public new ValueTask<IList<ToDoListEntity>> GetByIdsAsync(IList<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default) =>
        base.GetByIdsAsync(ids, asNoTracking, cancellationToken);

    public new ValueTask<ToDoListEntity> CreateAsync(ToDoListEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default) =>
        base.CreateAsync(entity, saveChanges, cancellationToken);

    public new ValueTask<ToDoListEntity> UpdateAsync(ToDoListEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default) =>
        base.UpdateAsync(entity, saveChanges, cancellationToken);

    public new ValueTask<ToDoListEntity> DeleteByIdAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default) =>
        base.DeleteByIdAsync(id, saveChanges, cancellationToken);
}