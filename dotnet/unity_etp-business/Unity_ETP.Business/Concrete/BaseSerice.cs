using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        private readonly IBaseRepostitory<TEntity,TPrimary> _currentRepostitory;
        public BaseSerice(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
            _currentRepostitory = _unitOfWork.Set<TEntity, TPrimary>();
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
                result = await _currentRepostitory.AddAsync(entity);
                await _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                return new ServiceResult<TEntity>
                {
                    IsSucceed = false,
                    ErrorCode = 500,
                    ErrorMsg = "Data Not Saved.",
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

        public async Task<ServiceResult<TEntity>> DeleteAsync(TPrimary id)
        {
            if(id == null) return new ServiceResult<TEntity>
            {
                IsSucceed = false,
                ErrorCode = 422,  //HttpStatusCode.UnprocessableEntity
                ErrorMsg = "Entity is null."
            };
            TEntity deleteItem;
            try
            {
                deleteItem = await _currentRepostitory.DeleteByIdAsync(id);
                await _unitOfWork.Commit();
            }
            catch (Exception ex)
            {

                return new ServiceResult<TEntity>
                {
                    IsSucceed = false,
                    ErrorCode = 500,  //HttpStatusCode.UnprocessableEntity
                    ErrorMsg = "Data Not Saved."
                };
            }

            if (deleteItem == null) return new ServiceResult<TEntity>
            {
                IsSucceed = false,
                ErrorCode = 500,  //HttpStatusCode.UnprocessableEntity
                ErrorMsg = "Result is null."
            };

            return new ServiceResult<TEntity>
            {
                Result = deleteItem,
                IsSucceed = true,
            };
        }

        public async Task<IList<TEntity>> GetAllAsync(bool isNotSelecedDelete = true)
        {
            return await _currentRepostitory.GetAllListAsync(isNotSelecedDelete);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool isFrist = true, bool isNotSelecedDelete = false)
        {
            return isFrist ? await _currentRepostitory.GetFristAsync(predicate): await _currentRepostitory.GetLastAsync(predicate);
        }

        public async Task<bool> IsFoundDataBase(TPrimary id)
        {
            if (id == null) return false;
            return await _currentRepostitory.AnyAsync(e => e.Id.Equals(id));
        }

        public async Task<ServiceResult<TEntity>> UpdateAsync(TEntity entity)
        {
            if(entity == null) return new ServiceResult<TEntity>
            {
                IsSucceed = false,
                ErrorCode = 422,  //HttpStatusCode.UnprocessableEntity
                ErrorMsg = "Entity is null."
            };

            TEntity updateItem;
            try
            {
                updateItem = await _currentRepostitory.UpdateAsync(entity);
                await _unitOfWork.Commit();
            }
            catch (Exception ex)
            {

                return new ServiceResult<TEntity>
                {
                    IsSucceed = false,
                    ErrorCode = 500,  //HttpStatusCode.UnprocessableEntity
                    ErrorMsg = "Data Not Saved."
                };
            }
            if(updateItem == null) return new ServiceResult<TEntity>
            {
                IsSucceed = false,
                ErrorCode = 500,  //HttpStatusCode.UnprocessableEntity
                ErrorMsg = "Entity Not Found."
            };

            return new ServiceResult<TEntity>
            {
                Result = updateItem,
                IsSucceed = true,
            };
            
        }
    }
}
