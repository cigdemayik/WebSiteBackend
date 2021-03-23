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
    public class BlogsController:ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _blogService.GetAll();
            if (response.IsSuccessful==true)
            {
                return Ok(response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_blogService.GetById(id));

        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            var response =_blogService.Create(blog);
            if (response.IsSuccessful == true)
            {
                return Created("", response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }
         
        [HttpPut]
        public IActionResult Update(Blog blog)
        {
            var response = _blogService.Update(blog);
            if (response.IsSuccessful==true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var response=_blogService.Delete(id);
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
