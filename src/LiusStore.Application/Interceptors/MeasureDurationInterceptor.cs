using Castle.Core.Logging;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LiusStore.Interceptors
{
    class MeasureDurationInterceptor : IInterceptor
    {
        public ILogger Logger { get; set; }
        public MeasureDurationInterceptor()
        {
            Logger = NullLogger.Instance;
        }
        public void Intercept(IInvocation invocation)
        {
            // Before methond execution
            // 方法执行前
            var stopwatch = Stopwatch.StartNew();

            // Executing the  actual method
            // 执行方法
            invocation.Proceed();

            // After method execution.
            // 方法执行结束
            stopwatch.Stop();
            Logger.InfoFormat("MeasureDurationInterceptor: {0} executed in {1} milliseconds.",
                invocation.MethodInvocationTarget.Name,
                stopwatch.ElapsedMilliseconds.ToString("0.000"));
        }
    }
}
