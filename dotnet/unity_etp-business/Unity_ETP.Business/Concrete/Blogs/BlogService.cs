using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unity_ETP.Business.Abstract.Blogs;
using Unity_ETP.Business.ServiceResults;
using UnityETP.DataAccess.Abstract;
using UnityETP.Entity.Blogs;

namespace Unity_ETP.Business.Concrete.Blogs
{
    public class BlogService : IBlogService
    {
        readonly IUnitOfWork _unitOfWork;

        public BlogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceResult<Blog>> AddAsync(Blog entity)
        {
            if (entity == null && entity.Detail == null) return new ServiceResult<Blog>
            {
                IsSucceed = false,
                ErrorCode = 422,//HttpStatusCode.UnprocessableEntity
                ErrorMsg = "Detail Not Found In Blog. Please Add Detail To Blog.",
                Result = entity
                
            };

            Blog result;
            try
            {
                 result = await _unitOfWork.BlogRepostitory.AddAsync(entity);
            }
            catch (Exception ex)
            {
                return new ServiceResult<Blog>
                {
                    IsSucceed = false,
                    ErrorCode = 500, // HttpStatusCode.InternalServerError
                    ErrorMsg = ex.Message,
                    Result = entity
                };
            }
            
            if(result == null) return new ServiceResult<Blog>
            {
                IsSucceed = false,
                ErrorCode = 500, // HttpStatusCode.InternalServerError
                ErrorMsg = "Blog Not Created.",
                Result = entity
            };

            return new ServiceResult<Blog>
            {
                Result = result,
                IsSucceed = true,
                ErrorCode = 201,
            };
        }

        public async Task<ServiceResult<Blog>> DeleteAsync(int id)
        {
            if (id == 0) return new ServiceResult<Blog>
            {
                Result = null,
                ErrorCode = 422,
                IsSucceed = false,
                ErrorMsg = "Entity is null"
            };
            var result = await _unitOfWork.BlogRepostitory.DeleteByIdAsync(id);
            if (result == null) return new ServiceResult<Blog>
            {
                IsSucceed = false,
                Result = null,
                ErrorCode = 500,
                ErrorMsg = "Data Not Deleted."
            };

            await _unitOfWork.Commit();
            return new ServiceResult<Blog> { Result = result, IsSucceed = true };
        }

        public async Task<IList<Blog>> GetAllAsync(bool isNotSelecedDelete = true)
        {
            return await _unitOfWork.BlogRepostitory.GetAllListAsync(isNotSelecedDelete);
        }

        public async Task<Blog> GetAsync(bool isFrist = true, bool isNotSelecedDelete = true)
        {
            return isFrist ? await _unitOfWork.BlogRepostitory.GetFristAsync(null, isNotSelecedDelete, x => x.Detail) : await _unitOfWork.BlogRepostitory.GetLastAsync(null,isNotSelecedDelete, x => x.Detail) ;
        }

        public async Task<Blog> GetAsync(Expression<Func<Blog, bool>> predicate, bool isFrist = true, bool isNotSelecedDelete = true)
        {
            if (predicate != null)
                return isFrist ? await _unitOfWork.BlogRepostitory.GetFristAsync(predicate, isNotSelecedDelete,x=>x.Detail) : await _unitOfWork.BlogRepostitory.GetLastAsync(predicate, isNotSelecedDelete, x => x.Detail);
            else return await GetAsync(isFrist, isNotSelecedDelete);
        }

        public async Task<bool> IsFoundDataBase(int id)
        {
            return await _unitOfWork.BlogRepostitory.AnyAsync(x => x.Id == id);
        }

        public async Task<ServiceResult<Blog>> UpdateAsync(Blog entity)
        {
            if (entity == null || entity.Detail == null) return new ServiceResult<Blog>
            {
                IsSucceed = true,
                ErrorCode = 422,
                ErrorMsg = "Entity is Null"
            };
            Blog blog;
            try
            {
                blog = await _unitOfWork.BlogRepostitory.UpdateAsync(entity);
                await _unitOfWork.Commit();
                if (blog == null) throw new Exception();
            }
            catch (Exception ex)
            {
                return new ServiceResult<Blog>
                {
                    IsSucceed = false,
                    ErrorCode = 500,
                    ErrorMsg = "Creating time problem."
                };
            }

            return new ServiceResult<Blog>
            {
                Result = blog,
                IsSucceed = true,
            };
        }
    }
}
