using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Business.Dtos.UserDtos;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController<User>
    {
   
        private readonly IUserService _userService;

        public UsersController (IUserService userService, IGenericService<User> genericService):base(genericService)
        {
             _userService= userService;
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = _userService.GetById(id);
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
