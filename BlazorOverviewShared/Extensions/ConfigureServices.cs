using Blazored.LocalStorage;
using BlazorJsInterop;
using BlazorOverviewShared.Pages.Authentication;
using BlazorOverviewShared.Pages.ComponentCommunication;
using BlazorOverviewShared.Pages.FetchData;
using BlazorOverviewShared.Pages.User;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using SharedComponents;

namespace BlazorOverviewShared.Extensions
{
    public static class ConfigureServices
    {
        public static void AddBlazorOverviewSharedServices(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();


            services.AddTransient<UserMock>();
            services.AddSingleton<RandomService>();
            services.AddSingleton<TimeState>();
            services.AddBlazorJsUtils();
            services.AddSharedComponentsUtils();

            services.AddBlazoredLocalStorage();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddScoped<AuthService>();
        }
    }
}


