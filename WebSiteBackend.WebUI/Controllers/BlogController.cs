using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _blogService.GetAllAsync();
            if (result.IsSuccessful)
            {
                return View(result.Result);
            }
            return BadRequest(result.ErrorMessage);
        }
        
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new Blog());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Blog model)
        {
            var result = await _blogService.CreateAsync(model);
            if (result.IsSuccessful)
            {
                return RedirectToAction("Index");
            }
            return BadRequest(result.ErrorMessage);
        }
        [HttpGet("{id}/Blog")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _blogService.DeleteAsync(id);
            }
            return RedirectToAction("Index");
        }
        //[HttpGet("{id}")]
        public async Task<IActionResult> Updated(int id)
        {
            if (ModelState.IsValid)
            {
                var result = _blogService.GetById(id);
                if (result.IsSuccessful)
                {
                    return View(result.Result);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(Blog model)
        {
            if (ModelState.IsValid)
            {
                await _blogService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest("Parametreler Uyuşmadı");
            }
        }
    }
}
