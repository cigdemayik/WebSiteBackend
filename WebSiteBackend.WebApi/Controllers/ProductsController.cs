using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebApi.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ProductsController:ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response=_productService.GetAll();
            if (response.IsSuccessful==true)
            {
                return Ok(response.Result);
            }
            else
            {
                return BadRequest(response.ErrorMessage);
            }
        }

        [HttpGet ("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            var response = _productService.Create(product);
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
        public IActionResult Update(Product product)
        {
           var response= _productService.Update(product);
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
            var response=_productService.Delete(id);
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
