using Directory.Core.Interfaces;
using Directory.Dto.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Directory.Core.Generics;

public abstract class RepositoryBase<T>(DbContext context) : IRepository<T> where T : DtoBase
{
    public virtual async Task<T> AddAsync(T entity, CancellationToken cancellationToken)
    {
        context.Add(entity);
        return entity;
    }

    public virtual async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        context.Update(entity);
        return entity;
    }

    public virtual async Task<T> GetAsync(long id, CancellationToken cancellationToken)
    {
        return await context.Set<T>().FindAsync([id], cancellationToken)
               ?? throw new KeyNotFoundException($"Entity with id {id} not found.");
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Set<T>().ToListAsync(cancellationToken);
    }

    public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
    {
        return await context.Set<T>().Where(predicate).ToListAsync(cancellationToken);
    }
}
