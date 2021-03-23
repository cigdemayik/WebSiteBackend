using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Abstracts.Interfaces.Generic;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController:BaseController<Category>
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService, IGenericService<Category> genericService):base(genericService)
        {
             _categoryService= categoryService;
        }

       
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_categoryService.GetById(id));
        }
    }
}
