using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity_ETP.Business.ServiceResults;
using UnityETP.Entity;

namespace Unity_ETP.Business.Abstract
{
    public  interface IBaseService<TEntity,TPrimary> 
        where TEntity : IBaseEntity<TPrimary>
    {
        Task<IList<TEntity>> GetAllAsync(bool isNotSelecedDelete=false);
        Task<TEntity> GetAsync(bool isFrist = true, bool isNotSelecedDelete = false);
        Task<ServiceResult<TEntity>> AddAsync(TEntity entity);
        Task<ServiceResult<TEntity>> UpdateAsync(TEntity entity);
        Task<ServiceResult<TEntity>> DeleteAsync(TPrimary id);
        Task<bool> IsFoundDataBase(TPrimary id);
    }
}
