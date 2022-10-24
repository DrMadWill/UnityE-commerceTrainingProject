using Unity_ETP.Business.Abstract;
using Unity_ETP.Business.Concrete;
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


            return services;
        }
    }
}
