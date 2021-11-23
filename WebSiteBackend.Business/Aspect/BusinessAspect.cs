using Autofac.Core;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.CrossCutttingConcerns;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Business.Aspect
{
    public class BusinessAspect : MethodInterception
    {
        WebSiteContext context;
        IUnitOfWork unitOfWork;
        List<ExceptionLog> logs;
        public BusinessAspect()
        {
            context = new WebSiteContext();
            unitOfWork = new UnitOfWork(context);
            logs = new List<ExceptionLog>();
        }
        protected override void OnBefore(IInvocation invocation)
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
                Method =invocation.Method.DeclaringType.ToString() +" / " + invocation.Method.Name,
                Message = $"Metod Başlıyor. Input: {argumetString}",

            };

            logs.Add(log);
        }
        protected override void OnAfter(IInvocation invocation)
        {
            WebSiteContext context = new WebSiteContext();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            
            string argumetString = "";
            foreach (var item in invocation.Arguments)
            {
                argumetString = argumetString +" " + item.ToString();
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
        protected override void OnException(IInvocation invocation,Exception ex)
        {
            WebSiteContext context = new WebSiteContext();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
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
            foreach (var item in logs)
            {
                unitOfWork.GetRepository<ExceptionLog>().Add(item);
            }
            
            unitOfWork.SaveChanges();
            logs = new List<ExceptionLog>();
        }
        protected override void OnSuccess(IInvocation invocation)
        {
            WebSiteContext context = new WebSiteContext();
            IUnitOfWork unitOfWork = new UnitOfWork(context);
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
            foreach (var item in logs)
            {
                unitOfWork.GetRepository<ExceptionLog>().Add(item);
            }

            unitOfWork.SaveChanges();
            logs = new List<ExceptionLog>();
        }
    }
}
