using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete;

namespace WebSiteBackend.WebUI.Controllers
{
    public class CarouselController : Controller
    {
        private readonly ICarouselService _carouselService;

        public CarouselController(ICarouselService carouselService)
        {
            _carouselService = carouselService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _carouselService.GetAllAsync();
            if (result.IsSuccessful)
            {
                return View(result.Result);
            }
            return BadRequest(result.ErrorMessage);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new Carousel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Carousel model)
        {
            var result = await _carouselService.CreateAsync(model);
            if (result.IsSuccessful)
            {
                return RedirectToAction("Index");
            }
            return BadRequest(result.ErrorMessage);
        }

        [HttpGet ("{id}/ Carousel")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _carouselService.DeleteAsync(id);
            }
            return BadRequest("Silme İşlemi Gerçekleştirilemedi.");
        }

        //[HttpGet("{id}")]
        public async Task<IActionResult> Update(int id)
        {
            if (ModelState.IsValid)
            {
                var result = _carouselService.GetById(id);
                return View(result.Result);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(Carousel model)
        {
            if (ModelState.IsValid)
            {
                await _carouselService.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest("Parametreler Uyuşmadı.");
            }           
        }
    }
}
