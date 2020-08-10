using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LiusStore.EntityFrameworkCore;
using LiusStore.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LiusStore.Web.Tests
{
    [DependsOn(
        typeof(LiusStoreWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LiusStoreWebTestModule : AbpModule
    {
        public LiusStoreWebTestModule(LiusStoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LiusStoreWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LiusStoreWebMvcModule).Assembly);
        }
    }
}