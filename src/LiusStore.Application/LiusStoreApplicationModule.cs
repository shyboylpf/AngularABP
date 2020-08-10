using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LiusStore.Authorization;

namespace LiusStore
{
    [DependsOn(
        typeof(LiusStoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LiusStoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LiusStoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LiusStoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
