using Microsoft.Extensions.DependencyInjection;

namespace BlazorJsInterop
{
    public static class BlazorJSUtils
    {
        public static IServiceCollection AddBlazorJsUtils(this IServiceCollection services)
        {
            return services.AddScoped<BlazorJsUtilsInterop>();
        }
    }
}
