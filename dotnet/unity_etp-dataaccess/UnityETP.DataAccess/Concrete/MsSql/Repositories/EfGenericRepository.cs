using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UnityETP.Entity;
using static UnityETP.DataAccess.Abstract.IBaseRepostitory;

namespace UnityETP.DataAccess.Concrete.MsSql.Repositories
{
    public class EfGenericRepository<TEntity, TPrimary> : IBaseRepostitory<TEntity, TPrimary>
        where TEntity : class, IBaseEntity<TPrimary>
    {
        private readonly AppDbContext _dbContext;
        private DbSet<TEntity> Table => _dbContext.Set<TEntity>();
        private IQueryable<TEntity> TableSelect => Table.Where(x => x.IsDelete == false).AsNoTracking();
        private IQueryable<TEntity> TableSelectWithSoftDelete => Table.AsNoTracking();

        public EfGenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll(bool isNotSelectSoftDelete = true)
        {
            IQueryable<TEntity> query = isNotSelectSoftDelete ? TableSelect : TableSelectWithSoftDelete;
            return query;
        }

        public async Task<List<TEntity>> GetAllList(bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllListIncluding(bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return await GetAllIncluding(isNotSelectSoftDelete, includeProperties).ToListAsync();
        }

        public IQueryable<TEntity> GetAllIncluding(bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = GetAll(isNotSelectSoftDelete);
            BindIncludeProperties(query, includeProperties);
            includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }

        public async ValueTask<TEntity> Find(TPrimary id) => await Table.FindAsync(id);

        public IQueryable<TEntity> FindAllBy(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return GetAll(isNotSelectSoftDelete).Where(predicate);
        }

        public IQueryable<TEntity> FindAllByInculding(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = GetAll(isNotSelectSoftDelete);
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query.Where(predicate);
        }

        public async Task<TEntity> GetFrist(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> GetLast(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).LastOrDefaultAsync(predicate);
        }

        public async Task<bool> Alll(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).AllAsync(predicate);
        }

        public async Task<bool> Any(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).AnyAsync(predicate);
        }

        public async Task<int> Count(bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).CountAsync();
        }

        public async Task<int> Count(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).CountAsync(predicate);
        }

        private void BindIncludeProperties(IQueryable<TEntity> query, IEnumerable<Expression<Func<TEntity, object>>> includeProperties)
        {
            includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public async Task<List<TEntity>> AddRange(List<TEntity> entity)
        {
            await Table.AddRangeAsync(entity);
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            Table.Update(entity);
            //_dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<List<TEntity>> UpdateRange(List<TEntity> entity)
        {
            Table.UpdateRange(entity);
            //_dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<TEntity> Delete(TEntity entity)
        {
            Table.Remove(entity);
            // _dbContext.Entry(entity).State = EntityState.Deleted;
            return entity;
        }

        public async Task<List<TEntity>> DeleteRange(List<TEntity> entity)
        {
            Table.RemoveRange(entity);
            // _dbContext.Entry(entity).State = EntityState.Deleted;
            return entity;
        }

        public async Task DeleteWhere(Expression<Func<TEntity, bool>> predicate)
        {
            List<TEntity> entities = FindAllBy(predicate).ToList();
            DeleteRange(entities);
            //foreach (var entity in entities)
            //{
            //    _dbContext.Entry(entity).State = EntityState.Deleted;
            //}
        }

        public async Task<TEntity> DeleteById(TPrimary id)
        {
            var entity = await GetFrist(x => x.Id.Equals(id));
            if (entity == null) return null;
            return await Delete(entity);
        }

        public async Task<TEntity> Remove(TEntity entity) // Hard Delete
        {
            Table.Remove(entity);
            // _dbContext.Entry(entity).State = EntityState.Deleted;
            return entity;
        }

        public async Task<List<TEntity>> RemoveRange(List<TEntity> entity) // Hard Delete
        {
            Table.RemoveRange(entity);
            // _dbContext.Entry(entity).State = EntityState.Deleted;
            return entity;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}