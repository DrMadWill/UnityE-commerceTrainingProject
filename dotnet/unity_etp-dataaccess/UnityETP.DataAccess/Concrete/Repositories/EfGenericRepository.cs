using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UnityETP.DataAccess.Abstract;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.Entity;


namespace UnityETP.DataAccess.Concrete.Repositories
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

        public async Task<List<TEntity>> GetAllListAsync(bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllListIncludingAsync(bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return await GetAllIncluding(isNotSelectSoftDelete, includeProperties).ToListAsync();
        }

        public IQueryable<TEntity> GetAllIncluding(bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = GetAll(isNotSelectSoftDelete);
            return BindIncludeProperties(query, includeProperties); ;
        }

        public async ValueTask<TEntity> Find(TPrimary id) => await Table.FindAsync(id);

        public IQueryable<TEntity> FindAllBy(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return GetAll(isNotSelectSoftDelete).Where(predicate);
        }

        public IQueryable<TEntity> FindAllByInculding(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = GetAll(isNotSelectSoftDelete);
            query = BindIncludeProperties(query, includeProperties);
            return query.Where(predicate);
        }

        public async Task<TEntity> GetFristAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> GetLastAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).LastOrDefaultAsync(predicate);
        }

        public async Task<bool> AllAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).AllAsync(predicate);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).AnyAsync(predicate);
        }

        public async Task<int> CountAsync(bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, bool isNotSelectSoftDelete = true)
        {
            return await GetAll(isNotSelectSoftDelete).CountAsync(predicate);
        }

        private IQueryable<TEntity> BindIncludeProperties(IQueryable<TEntity> query, IEnumerable<Expression<Func<TEntity, object>>> includeProperties)
        {
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            entity.CreateAt = DateTime.Now;
            await Table.AddAsync(entity);
            return entity;
        }

        public async Task<List<TEntity>> AddRangeAsync(List<TEntity> entities)
        {
            entities.ForEach(entitiy => entitiy.CreateAt = DateTime.Now);
            await Table.AddRangeAsync(entities);
            return entities;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.UpdateAt = DateTime.Now;
            Table.Update(entity);
            //_dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entities)
        {
            entities.ForEach(entity => entity.UpdateAt = DateTime.Now);
            Table.UpdateRange(entities);
            //_dbContext.Entry(entity).State = EntityState.Modified;
            return entities;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            entity.IsDelete = true;
            Table.Update(entity);
            // _dbContext.Entry(entity).State = EntityState.Deleted;
            return entity;
        }

        public async Task<List<TEntity>> DeleteRangeAsync(List<TEntity> entities)
        {
            entities.ForEach((e) => e.IsDelete = true);
            Table.UpdateRange(entities);
            // _dbContext.Entry(entity).State = EntityState.Deleted;
            return entities;
        }

        public async Task DeleteWhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            List<TEntity> entities = FindAllBy(predicate).ToList();
            await DeleteRangeAsync(entities);
            //foreach (var entity in entities)
            //{
            //    _dbContext.Entry(entity).State = EntityState.Deleted;
            //}
        }

        public async Task<TEntity> DeleteByIdAsync(TPrimary id)
        {
            var entity = await GetFristAsync(x => x.Id.Equals(id));
            if (entity == null) return null;
            return await DeleteAsync(entity);
        }

        public async Task<TEntity> RemoveAsync(TEntity entity) // Hard Delete
        {
            Table.Remove(entity);
            // _dbContext.Entry(entity).State = EntityState.Deleted;
            return entity;
        }

        public async Task<List<TEntity>> RemoveRangeAsync(List<TEntity> entities) // Hard Delete
        {
            Table.RemoveRange(entities);
            // _dbContext.Entry(entity).State = EntityState.Deleted;
            return entities;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}