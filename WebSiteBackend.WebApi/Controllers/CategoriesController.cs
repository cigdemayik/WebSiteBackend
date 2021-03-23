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
    public class CategoriesController:ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
             _categoryService= categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response=_categoryService.GetAll();
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
            return Ok(_categoryService.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            var response = _categoryService.Create(category);
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
        public IActionResult Update(Category category)
        {
            var response=_categoryService.Update(category);
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
            var response=_categoryService.Delete(id);
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
