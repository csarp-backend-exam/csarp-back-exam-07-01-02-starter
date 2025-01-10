using Kreta.Shared.Models;
using Kreta.Shared.Responses;
using System.Linq.Expressions;

namespace Kreta.Backend.Repos.Base
{
    public interface IBaseRepo<TEntity> where TEntity : class, IDbEntity<TEntity>, new()
    {
        IQueryable<TEntity> GetEmpty();
        IQueryable<TEntity> FindAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
        Task<Response> UpdateAsync(TEntity entity);
        Task<Response> CreateAsync(TEntity entity);
        Task<Response> DeleteAsync(Guid id);
    }
}
