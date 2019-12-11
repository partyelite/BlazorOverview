using Microsoft.Extensions.DependencyInjection;

namespace SharedComponents
{
    public static class SharedComponentsUtils
    {
        public static IServiceCollection AddSharedComponentsUtils(this IServiceCollection services)
        {
            return services.AddScoped<JSInterop>();
        }
    }
}
