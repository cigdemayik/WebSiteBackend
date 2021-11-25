

using Castle.Core.Logging;
using Castle.DynamicProxy;
using WebSiteBackend.Helpers.CrossCutttingConcerns;

namespace WebSiteBackend.Business.Aspect.AspectMarker
{

    public class BusinessLogMarkerAttribute : MethodInterception
    {
        ILogger _logger;

        public BusinessLogMarkerAttribute(ILogger logger)
        {
            _logger = NullLogger.Instance;
        }

        protected override void OnBefore(IInvocation invocation)
        {

            string argumetString = "";
            foreach (var item in invocation.Arguments)
            {
                argumetString = argumetString + " " + item.ToString();
            }

           
        }
    }
}
