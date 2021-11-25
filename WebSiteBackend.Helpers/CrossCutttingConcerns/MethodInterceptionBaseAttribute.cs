using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Helpers.CrossCutttingConcerns
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method)]
    public abstract class MethodInterceptionBaseAttribute : Attribute,  IInterceptor
    {
        public int Priority { get; set; }
        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
