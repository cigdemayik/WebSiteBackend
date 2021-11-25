using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WebSiteBackend.Helpers.CrossCutttingConcerns
{
    public class AspectInterceptorSelector: IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAtt = type.GetCustomAttributes<MethodInterception>(true).ToList();
            if (classAtt.Count == 0)
                return null;

            var methodAtt = type.GetMethod(method.Name).GetCustomAttributes<MethodInterception>(true);

            classAtt.AddRange(methodAtt);

            return classAtt.OrderBy(x => x.Priority).ToArray();
        }
    }
}
