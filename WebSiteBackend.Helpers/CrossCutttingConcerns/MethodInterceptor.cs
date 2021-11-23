using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Helpers.CrossCutttingConcerns
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        //Method Çalışmadan önce
        protected virtual void OnBefore(IInvocation invocation)
        {
        }
        //Method Çalıştıktan sonra
        protected virtual void OnAfter(IInvocation invocation)
        {
        }
        //Method Exception'a düşerse
        protected virtual void OnException(IInvocation invocation,Exception ex)
        {
        }
        //Method başarıyla bitirilirse
        protected virtual void OnSuccess(IInvocation invocation)
        {
        }

        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            this.OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                this.OnException(invocation,ex);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    this.OnSuccess(invocation);
                }
            }
            this.OnAfter(invocation);
        }
    }
}
