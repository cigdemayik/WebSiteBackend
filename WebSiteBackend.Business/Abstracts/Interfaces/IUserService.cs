using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Business.Dtos.UserDtos;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IUserService:IGenericService<User>
    {
        ServiceResponse<User> GetById(int id);

        ServiceResponse<UserLoginResponseDto> SignIn(UserLoginDto dto);
    }
}
