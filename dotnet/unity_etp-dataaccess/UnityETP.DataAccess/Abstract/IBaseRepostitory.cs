using System.Linq.Expressions;
using UnityETP.Entity;

namespace UnityETP.DataAccess.Abstract
{
    public interface IBaseRepostitory<TEntity, in TPrimary> : IDisposable
        where TEntity : IBaseEntity<TPrimary>
    {
        IQueryable<TEntity> GetAll(bool isNotSelectSoftDelete = true);

        Task<List<TEntity>> GetAllList(bool isNotSelectSoftDelete = true);

        IQueryable<TEntity> GetAllIncluding(bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties);

        Task<List<TEntity>> GetAllListIncluding(bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties);

        ValueTask<TEntity> Find(TPrimary id);

        Task<TEntity> GetFrist(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        Task<TEntity> GetLast(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        IQueryable<TEntity> FindAllBy(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        IQueryable<TEntity> FindAllByInculding(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties);

        Task<bool> Any(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        Task<bool> Alll(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        Task<int> Count(bool isNotSelectSoftDelete = true);

        Task<int> Count(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true);

        Task<TEntity> Add(TEntity entity);

        Task<List<TEntity>> AddRange(List<TEntity> entities);

        Task<TEntity> Update(TEntity entity);

        Task<List<TEntity>> UpdateRange(List<TEntity> entities);

        Task<TEntity> Delete(TEntity entity); // Soft Delete

        Task<List<TEntity>> DeleteRange(List<TEntity> entities); // Soft Delete

        Task<TEntity> DeleteById(TPrimary id);// Soft Delete

        Task DeleteWhere(Expression<Func<TEntity, bool>> predicate); //Soft Delete

        Task<TEntity> Remove(TEntity entity); // Hard Delete

        Task<List<TEntity>> RemoveRange(List<TEntity> entities); // Hard Delete
    }
}