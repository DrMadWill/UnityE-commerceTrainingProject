using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityETP.Entity;

namespace Unity_ETP.Business.Abstract
{
    public  interface IBaseRepository<TEntity,TPrimary> 
        where TEntity : IBaseEntity<TPrimary>
    {
        Task<IList<TEntity>> GetAllAsync(bool isNotSelecedDelete=false);
        Task<TEntity> GetAsync(bool isFrist = true, bool isNotSelecedDelete = false);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TPrimary id);
        Task<bool> IsFoundDataBase(TPrimary id);
    }
}
