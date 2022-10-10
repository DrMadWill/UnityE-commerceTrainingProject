using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity_ETP.Business.Abstract.Blogs;
using UnityETP.Entity.Blogs;

namespace Unity_ETP.Business.Concrete.Blogs
{
    public class BlogRepository : IBlogRepository
    {
        public Task<Blog> AddAsync(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> DeleteAsync(int id)
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

        public Task<Blog> UpdateAsync(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
