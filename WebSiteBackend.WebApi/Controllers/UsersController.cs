using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
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

        [HttpGet]
        public IActionResult GetAll()
        {
            var response=_userService.GetAll();
            if (response.IsSuccessful==true)
            {
                return Ok(response.Result);
            }
            else
            {
                return BadRequest(response.Result);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            var response = _userService.Create(user);
            if (response.IsSuccessful==true)
            {
                return Created("", response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        [HttpPut]
        public IActionResult Update(User user)
        {
            var response=_userService.Update(user);
            if (response.IsSuccessful==true)
            {
                return NoContent() ;
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response=_userService.Delete(id);
            if (response.IsSuccessful==true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }
    }
}
