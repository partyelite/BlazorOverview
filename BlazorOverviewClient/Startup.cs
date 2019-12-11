using BlazorOverviewShared.Extensions;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorOverviewClient
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorOverviewSharedServices();
            services.AddAuthorizationCore();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<BlazorOverviewShared.Shared.App>("app");
        }
    }
}
