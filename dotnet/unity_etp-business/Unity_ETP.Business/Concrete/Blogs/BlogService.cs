using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public Task<ServiceResult<Blog>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Blog>> GetAllAsync(bool isNotSelecedDelete = false)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> GetAsync(bool isFrist = true, bool isNotSelecedDelete = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsFoundDataBase(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<Blog>> UpdateAsync(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
