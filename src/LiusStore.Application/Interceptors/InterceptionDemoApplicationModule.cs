using Abp.Modules;
using LiusStore.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiusStore
{
    public class InterceptionDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            MeasureDurationInterceptorRegistrar.Initialize(IocManager.IocContainer.Kernel);
        }
    }
}