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
    [Route ("api/[controller]")]
    [ApiController]
    public class ProductsController:BaseController<Product>
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService, IGenericService<Product> genericService):base(genericService)
        {
            _productService = productService;
        }

    
        [HttpGet ("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetById(id));
        }
    }
}
