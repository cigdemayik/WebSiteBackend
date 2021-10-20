using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAllAsync();
            if (result.IsSuccessful)
            {

                return View(result.Result);
            }
            return BadRequest(result.ErrorMessage);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category model)
        {
            var result = await _categoryService.CreateAsync(model);
            if (result.IsSuccessful)
            {
                return RedirectToAction("Index");
            }
            return BadRequest(result.ErrorMessage);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _categoryService.DeleteAsync(id);
                return RedirectToAction("Index");
            }
            return BadRequest("Silme İşlemi Gerçekleştirilemedi");
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Update(int id)
        {
                var result = _categoryService.GetById(id);
                return View(result.Result);
         
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Update([FromForm]Category model)
        {
            if(ModelState.IsValid)
            {
                await _categoryService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest("Yolladığınız parametreler eşlememektedir");
            }
        }
    }
}


