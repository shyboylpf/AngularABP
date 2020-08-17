using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiusStore.Interceptors
{
    public class InterceptionDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            MeasureDurationInterceptorRegistrar.Initialize(IocManager.IocContainer.Kernel);
        }
    }
}