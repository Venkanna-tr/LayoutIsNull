using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure.Modules;

namespace SimplCommerce.Module.ActivityLog
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
