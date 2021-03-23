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
    public class BlogsController:BaseController<Blog>
    {
        private readonly IBlogService _blogService;

        public BlogsController(IBlogService blogService, IGenericService<Blog> genericService):base(genericService)
        {
            _blogService = blogService;

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = _blogService.GetById(id);
            
            return Ok();

        }
    }
}
