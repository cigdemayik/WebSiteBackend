using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces;
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

            if (user != null)
            {

                var tokenresponse= GenerateToken(user);
                

                return _serviceResponseHelper.SetSuccess(tokenresponse, HttpStatusCode.Created);

            }
            return _serviceResponseHelper.SetError<UserLoginResponseDto>(null,"Kullanıcı Adı ve Şifre Eşleşmemektedir"
                , HttpStatusCode.NotFound);
        }
        private UserLoginResponseDto GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("BANAYALANSOYLEDILER!soylediler");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Audience = "Application",
                Issuer = "WebSiteDemo",
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Name, user.Username)
                }),
                Expires = DateTime.UtcNow.AddDays(7),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            var userLoginResponseDto = new UserLoginResponseDto()
            {
                Token = tokenString,
                UserId = user.Id
            };
            return userLoginResponseDto;
        }
    }
}
