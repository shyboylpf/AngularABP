using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LiusStore.Configuration;

namespace LiusStore.Web.Host.Startup
{
    [DependsOn(
       typeof(LiusStoreWebCoreModule))]
    public class LiusStoreWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LiusStoreWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LiusStoreWebHostModule).GetAssembly());
        }
    }
}
