using System.Linq.Expressions;
using UnityETP.Entity;

namespace UnityETP.DataAccess.Abstract
{
    public interface IBaseRepostitory<TEntity, in TPrimary> : IDisposable
        where TEntity : IBaseEntity<TPrimary>
    {
        IQueryable<TEntity> GetAll(bool isNotSelectSoftDelete = true);

        Task<List<TEntity>> GetAllListAsync(bool isNotSelectSoftDelete = true);

        IQueryable<TEntity> GetAllIncluding(bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties);

        Task<List<TEntity>> GetAllListIncludingAsync(bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties);

        ValueTask<TEntity> Find(TPrimary id);

        Task<TEntity> GetFristAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        Task<TEntity> GetLastAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        IQueryable<TEntity> FindAllBy(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        IQueryable<TEntity> FindAllByInculding(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        Task<bool> AllAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        Task<int> CountAsync(bool isNotSelectSoftDelete = true);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        Task<TEntity> AddAsync(TEntity entity);

        Task<List<TEntity>> AddRangeAsync(List<TEntity> entities);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entities);

        Task<TEntity> DeleteAsync(TEntity entity); // Soft Delete

        Task<List<TEntity>> DeleteRangeAsync(List<TEntity> entities); // Soft Delete

        Task<TEntity> DeleteByIdAsync(TPrimary id);// Soft Delete

        Task DeleteWhereAsync(Expression<Func<TEntity, bool>> predicate); //Soft Delete

        Task<TEntity> RemoveAsync(TEntity entity); // Hard Delete

        Task<List<TEntity>> RemoveRangeAsync(List<TEntity> entities); // Hard Delete
    }
}