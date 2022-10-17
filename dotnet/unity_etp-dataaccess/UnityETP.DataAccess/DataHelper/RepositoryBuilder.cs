using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityETP.DataAccess.Abstract;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.DataAccess.Concrete.Repositories;
using UnityETP.Entity;

namespace UnityETP.DataAccess.DataHelper
{
    public class RepositoryBuilder
    {
        public static IBaseRepostitory<TEntity, TPrimary> Builder<TEntity, TPrimary>
            (IBaseRepostitory<TEntity, TPrimary> repostitory, AppDbContext dbContext) where TEntity : class, IBaseEntity<TPrimary>

        {
            repostitory ??= new EfGenericRepository<TEntity, TPrimary>(dbContext);
            return repostitory;
        }
    }
}
