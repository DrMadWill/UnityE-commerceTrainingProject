using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnityETP.Entity;

namespace UnityETP.DataAccess.Abstract
{
    public interface IBaseRepostitory
    {
        public interface IBaseRepostitory<TEntity, in TPrimary> : IDisposable
        where TEntity : IBaseEntity<TPrimary>
        {
            IQueryable<TEntity> GetAll();
            Task<List<TEntity>> GetAllList();
            IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
            Task<List<TEntity>> GetAllListIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
            
            ValueTask<TEntity> Find(TPrimary id);

            Task<TEntity> GetFrist(Expression<Func<TEntity, bool>> predicate);
            Task<TEntity> GetLast(Expression<Func<TEntity, bool>> predicate);
            
            IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
            IQueryable<TEntity> FindByInculding(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

            Task<bool> Any(Expression<Func<TEntity, bool>> predicate);
            Task<bool> Alll(Expression<Func<TEntity, bool>> predicate);

            Task<int> Count();
            Task<int> Count(Expression<Func<TEntity, bool>> predicate);

            Task<TEntity> Add(TEntity entity); 
            Task<TEntity> AddRange(List<TEntity> entity);

            Task<TEntity> Update(TEntity entity);
            Task<TEntity> UpdateRange(List<TEntity> entity);

            Task<TEntity> Delete(TEntity entity); // Soft Delete
            Task<TEntity> DeleteRange(List<TEntity>  entity); // Soft Delete

            Task<TEntity> DeleteById(TPrimary id);// Soft Delete
            Task DeleteWhere(Expression<Func<TEntity, bool>> predicate); //Soft Delete 

            Task<TEntity> Remove(TEntity entity); // Hard Delete
            Task<TEntity> RemoveRange(List<TEntity> entity); // Hard Delete

        }

    }
}
