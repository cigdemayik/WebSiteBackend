using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.UserDtos;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
   
        private readonly IUserService _userService;

        public UsersController (IUserService userService)
        {
             _userService= userService;
        }

        public IActionResult Index()
        {
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public IActionResult SignIn(UserLoginDto dto)
        {
            var response = _userService.SignIn(dto);
            if (response.StatusCode==System.Net.HttpStatusCode.Created)
            {
                return Created("", response.Result);
            }
            else
            {
                return NotFound(response.ErrorMessage);
            }
        }
    }
}
