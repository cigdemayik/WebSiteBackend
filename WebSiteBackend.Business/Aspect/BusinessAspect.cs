using Autofac;
using Autofac.Core;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSiteBackend.Business.Aspect.AspectMarker;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.CrossCutttingConcerns;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Business.Aspect
{
    public class BusinessAspect : MethodInterception,IBusinessAspect
    {
        List<ExceptionLog> logs;
        private readonly IUnitOfWork _uow;

        public BusinessAspect(IUnitOfWork uow)
        {
            logs = new List<ExceptionLog>();
            _uow = uow;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            if (invocation.MethodInvocationTarget.GetCustomAttributes(typeof(BusinessLogMarkerAttribute), true).Any())
            {
                string argumetString = "";
                foreach (var item in invocation.Arguments)
                {
                    argumetString = argumetString + " " + item.ToString();
                }

                var log = new ExceptionLog()
                {
                    Id = new Guid(),
                    Layer = (int)LogLayerEnum.Business,
                    Method = invocation.Method.DeclaringType.ToString() + " / " + invocation.Method.Name,
                    Message = $"Metod Başlıyor. Input: {argumetString}",

                };

                logs.Add(log);
            }
            
        }
        protected override void OnAfter(IInvocation invocation)
        {
            if (invocation.MethodInvocationTarget.GetCustomAttributes(typeof(BusinessLogMarkerAttribute), true).Any())
            {
                string argumetString = "";
                foreach (var item in invocation.Arguments)
                {
                    argumetString = argumetString + " " + item.ToString();
                }

                var log = new ExceptionLog()
                {
                    Id = new Guid(),
                    Layer = (int)LogLayerEnum.Business,
                    Method = invocation.Method.DeclaringType.ToString() + " / " + invocation.Method.Name,
                    Message = $"Metod Bitti. Input: {argumetString} / Output: {invocation.ReturnValue.GetType()}"
                };
                logs.Add(log);
            }
        }
        protected override void OnException(IInvocation invocation,Exception ex)
        {
            if (invocation.MethodInvocationTarget.GetCustomAttributes(typeof(BusinessLogMarkerAttribute), true).Any())
            {
                string argumetString = "";
                foreach (var item in invocation.Arguments)
                {
                    argumetString = argumetString + " " + item.ToString();
                }

                var log = new ExceptionLog()
                {
                    Id = new Guid(),
                    Layer = (int)LogLayerEnum.Business,
                    Method = invocation.Method.DeclaringType.ToString() + " / " + invocation.Method.Name,
                    Message = $"Metod çalıştırılırken Bir Exception ile karşılaşıldı. Input: {argumetString} / Output: {invocation.ReturnValue.GetType()} // {ex.Message.ToString()}",
                    InnerMessage = $"{ex.InnerException.ToString()}"

                };

                logs.Add(log);
                _uow.GetRepository<ExceptionLog>().AddBulk(logs);

                _uow.SaveChanges();
            }
        }
        protected override void OnSuccess(IInvocation invocation)
        {

            if (invocation.MethodInvocationTarget.GetCustomAttributes(typeof(BusinessLogMarkerAttribute), true).Any())
            {
                string argumetString = "";
                foreach (var item in invocation.Arguments)
                {
                    argumetString = argumetString + " " + item.ToString();
                }

                var log = new ExceptionLog()
                {
                    Id = new Guid(),
                    Layer = (int)LogLayerEnum.Business,
                    Method = invocation.Method.DeclaringType.ToString() + " / " + invocation.Method.Name,
                    Message = $"Metod Başarı Ile Gerçekleştirildi. Input: {argumetString} / Output: {invocation.ReturnValue.GetType()}",

                };

                logs.Add(log);
                _uow.GetRepository<ExceptionLog>().AddBulk(logs);

                _uow.SaveChanges();
            }
        }
    }
}
