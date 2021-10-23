using WebSiteBackend.Business.Dtos.UserDtos;
using WebSiteBackend.Entities.Concrete;
using WebSiteBackend.Helpers.ServiceHelpers.Concrete;

namespace WebSiteBackend.Business.Abstracts.Interfaces
{
    public interface IUserService
    {
        ServiceResponse<UserLoginResponseDto> SignIn(UserLoginDto dto);
    }
}
