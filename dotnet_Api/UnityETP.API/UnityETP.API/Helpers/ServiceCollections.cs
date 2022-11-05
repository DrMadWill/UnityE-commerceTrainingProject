using Unity_ETP.Business.Abstract;
using Unity_ETP.Business.Abstract.Blogs;
using Unity_ETP.Business.Concrete;
using Unity_ETP.Business.Concrete.Blogs;
using UnityETP.DataAccess.Abstract;
using UnityETP.DataAccess.Concrete;
using UnityETP.DataAccess.Concrete.Repositories;

namespace UnityETP.API.Helpers
{
    public static class ServiceCollections
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped(typeof(IBaseRepostitory<,>), typeof(EfGenericRepository<,>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IBaseService<,>), typeof(BaseSerice<,>));
            services.AddScoped<IBlogService, BlogService>();

            return services;
        }
    }
}
