using Microsoft.AspNetCore.Mvc;
using WebSiteBackend.Business.Abstracts.Interfaces;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ProductsController: ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
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
