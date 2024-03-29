using System.Linq.Expressions;
using KodlamaIOSimulation.Entities.Abstract;

namespace KodlamaIOSimulation.DataAccess.Abstract;

public interface IRepository<TEntity>
where TEntity : BaseEntity, new()
{
    bool Any(Expression<Func<TEntity, bool>> expression);
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
    IQueryable<TEntity> GetAll();
    IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression);
    Task<TEntity?> GetByExpressionAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
    TEntity? GetByExpression(Expression<Func<TEntity, bool>> expression);
    Task<TEntity?> GetFirstAsync(CancellationToken cancellationToken = default);
    TEntity? GetFirst();
    Task<TEntity?> GetByIdAsync(string id, CancellationToken cancellationToken = default);
    TEntity? GetByExpression(string id);
    Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    void Add(TEntity entity);
    void AddRange(ICollection<TEntity> entities);
    Task AddRangeAsync(ICollection<TEntity> entities, CancellationToken cancellationToken = default);
    void Update(TEntity entity);
    void UpdateRange(ICollection<TEntity> entities);
    Task DeleteByExpressionAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
    void Delete(TEntity entity);
    void DeleteRange(ICollection<TEntity> entities);
}
