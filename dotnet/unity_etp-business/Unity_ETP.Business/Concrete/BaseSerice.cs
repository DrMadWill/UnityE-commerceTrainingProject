using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Unity_ETP.Business.Abstract;
using Unity_ETP.Business.ServiceResults;
using UnityETP.DataAccess.Abstract;
using UnityETP.Entity;

namespace Unity_ETP.Business.Concrete
{
    public class BaseSerice<TEntity, TPrimary> : IBaseService<TEntity, TPrimary>
        where TEntity : class, IBaseEntity<TPrimary>
    {
        private readonly IUnitOfWork _unitOfWork;
        public BaseSerice(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }

        public async Task<ServiceResult<TEntity>> AddAsync(TEntity entity)
        {
            if (entity == null) return new ServiceResult<TEntity>
            {
                IsSucceed = false,
                Result = entity,
                ErrorCode = 422,  //HttpStatusCode.UnprocessableEntity
                ErrorMsg = "Entity is null."
            };
            TEntity result = null;
            try
            {
                result = await _unitOfWork.Set<TEntity, TPrimary>(_unitOfWork).AddAsync(entity);
                await _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                return new ServiceResult<TEntity>
                {
                    IsSucceed = false,
                    ErrorCode = 500,
                    ErrorMsg = ex.Message,
                    Result = entity
                };
            }

            if(result == null) return new ServiceResult<TEntity>
            {
                IsSucceed = false,
                ErrorCode = 500,
                ErrorMsg = "Result is null.",
                Result = entity
            };


            return new ServiceResult<TEntity>
            {
                IsSucceed = true,
                Result = entity,
            };
        }

        public Task<ServiceResult<TEntity>> DeleteAsync(TPrimary id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<TEntity>> GetAllAsync(bool isNotSelecedDelete = false)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(bool isFrist = true, bool isNotSelecedDelete = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsFoundDataBase(TPrimary id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<TEntity>> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
