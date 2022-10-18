namespace UnityETP.API.Helpers
{
    public static class RegisterService
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services;
        }
    }
}
