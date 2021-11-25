using Autofac.Extras.DynamicProxy;
using Mapster;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Net;
using System.Security.Claims;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Aspect;
using WebSiteBackend.Business.Dtos.UserDtos;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Abstract;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceResponseHelper _serviceResponseHelper;

        public UserManager(IUnitOfWork unitOfWork, IServiceResponseHelper serviceResponseHelper)
        {
            _unitOfWork = unitOfWork;
            _serviceResponseHelper = serviceResponseHelper;
        }

        public ServiceResponse<User> GetById(int id)
        {
            var includes = new List<Expression<Func<User, object>>>();
            includes.Add(x => x.Blogs);
            var data = _unitOfWork.GetRepository<User>().GetByFilter(x => x.Id == id);
            if (data == null)
            {
                return _serviceResponseHelper.SetError<User>(data, "Product Bulunamadı", HttpStatusCode.NotFound);
            }
            else
            {
                return _serviceResponseHelper.SetSuccess(data, HttpStatusCode.OK);
            }
        }

        public ServiceResponse<UserLoginResponseDto> SignIn(UserLoginDto dto)
        {
            var user = _unitOfWork.GetRepository<User>().GetByFilter(x => x.Username == dto.Username && x.Password == dto.Password);
            var mappedData = user.Adapt<UserLoginResponseDto>();
            if (user != null)
            {
                

                return _serviceResponseHelper.SetSuccess(mappedData, HttpStatusCode.Created);

            }
            return _serviceResponseHelper.SetError<UserLoginResponseDto>(null,"Kullanıcı Adı ve Şifre Eşleşmemektedir"
                , HttpStatusCode.NotFound);
        }
    }
}
