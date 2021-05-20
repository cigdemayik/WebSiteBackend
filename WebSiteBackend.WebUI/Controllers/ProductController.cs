using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetAllAsync();
            if (result.IsSuccessful)
            {
                return View(result.Result);
            }
            return BadRequest(result.ErrorMessage);
        }

        
        public async Task<IActionResult> Create()
        {
            return View(new Blog());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product model)
        {
            var result = await _productService.CreateAsync(model);
            if (result.IsSuccessful)
            {
                return RedirectToAction("Index");
            }
            return BadRequest(result.ErrorMessage);
        }

        [HttpGet("{id}/Product")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _productService.DeleteAsync(id);
            }
            return BadRequest("Silme İşlemi Gerçekleştirilemedi");
        }

        //[HttpGet("{id}")]
        public async Task<IActionResult> Update(int id)
        {
            if (ModelState.IsValid)
            {
                var result = _productService.GetById(id);
                return View(result.Result);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Product model)
        {
            if (ModelState.IsValid)
            {
                await _productService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest("Parametreler Uyuşmadı");
            }
        }
    }
}
