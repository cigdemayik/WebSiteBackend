using Castle.DynamicProxy;
using Microsoft.AspNetCore.Http;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Helpers.CrossCutttingConcerns;

namespace WebSiteBackend.Business.Aspect.AspectMarker
{

    public class BusinessLogAspect : MethodInterception
    {
        ILogger logger;
        public BusinessLogAspect()
        {
            logger = Log.Logger;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var name = $"{invocation.Method.DeclaringType}.{invocation.Method.Name}";
            var args = string.Join(",", invocation.Arguments.Select(a => (a ?? "").ToString()));

            logger.Information($"Method Name => {name} // Args => {args}");
        }
        protected override void OnAfter(IInvocation invocation)
        {
            var name = $"{invocation.Method.DeclaringType}.{invocation.Method.Name}";
            var args = string.Join(",", invocation.Arguments.Select(a => (a ?? "").ToString()));
            var result = string.Join(",", invocation.ReturnValue.ToString());

            logger.Information($"Method Name => {name} // Args => {args} // Result => {result}");
        }
        protected override void OnException(IInvocation invocation, Exception ex)
        {
            var name = $"{invocation.Method.DeclaringType}.{invocation.Method.Name}";
            var args = string.Join(",", invocation.Arguments.Select(a => (a ?? "").ToString()));
            var result = string.Join(",", invocation.ReturnValue.ToString());

            logger.Error($"Method Name => {name} // Args => {args} // Result => {result}");
        }
        protected override void OnSuccess(IInvocation invocation)
        {
            var name = $"{invocation.Method.DeclaringType}.{invocation.Method.Name}";
            var args = string.Join(",", invocation.Arguments.Select(a => (a ?? "").ToString()));
            var result = string.Join(",", invocation.ReturnValue.ToString());

            logger.Information($"Method Name => {name} // Args => {args} // Result => {result}");
        }
    }
}