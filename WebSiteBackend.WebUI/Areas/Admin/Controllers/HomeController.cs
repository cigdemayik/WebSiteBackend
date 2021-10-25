using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.AboutUsDtos;
using WebSiteBackend.Business.Dtos.BlogDtos;
using WebSiteBackend.Business.Dtos.CarouselDtos;
using WebSiteBackend.Business.Dtos.CategoryDtos;
using WebSiteBackend.Business.Dtos.ProductDtos;
using WebSiteBackend.WebUI.Areas.Admin.Models.AboutUsModels;

namespace WebSiteBackend.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ICarouselService _carouselService;
        private readonly IBlogService _blogService;
        private readonly IAboutUsService _aboutUsService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ICategoryService categoryService, IProductService productService, ICarouselService carouselService, IBlogService blogService, IAboutUsService aboutUsService, IWebHostEnvironment webHostEnvironment)
        {
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _carouselService = carouselService ?? throw new ArgumentNullException(nameof(carouselService));
            _blogService = blogService ?? throw new ArgumentNullException(nameof(blogService));
            _aboutUsService = aboutUsService ?? throw new ArgumentNullException(nameof(aboutUsService));
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Category 

        public async Task<IActionResult> Category()
        {
            var response = await _categoryService.GetAll();
            if(response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result);
        }

        public async Task<IActionResult> CategoryCreate()
        {
            return View(new CategoryCreateDto());
        }
        [HttpPost]
        public async Task<IActionResult> CategoryCreate(CategoryCreateDto dto)
        {
            var response = await _categoryService.Create(dto);
            if(response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Category");
        }

        public async Task<IActionResult> CategoryUpdate(int id)
        {
            var response = await _categoryService.GetById(id);
            if(response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result);
        }
        [HttpPost]
        public async Task<IActionResult> CategoryUpdate(CategoryUpdateDto dto)
        {
            var response = await _categoryService.Update(dto);
            if(response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Category");
        }

        public async Task<IActionResult> CategoryDelete(int id)
        {
            var response = await _categoryService.Delete(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return BadRequest();
                
            return RedirectToAction("Category");
        }

        public async Task<IActionResult> CategoryChangeStatus(int id)
        {
            var response = await _categoryService.Delete(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return BadRequest();

            return RedirectToAction("Category");
        }
        #endregion

        #region Blog

        public async Task<IActionResult> Blog()
        {
            var response = await _blogService.GetAll();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result);
        }

        public async Task<IActionResult> BlogCreate()
        {
            return View(new BlogCreateDto());
        }
        [HttpPost]
        public async Task<IActionResult> BlogCreate(BlogCreateDto dto)
        {
            var response = await _blogService.Create(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Blog");
        }

        public async Task<IActionResult> BlogUpdate(int id)
        {
            var response = await _blogService.GetById(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result);
        }
        [HttpPost]
        public async Task<IActionResult> BlogUpdate(BlogUpdateDto dto)
        {
            var response = await _blogService.Update(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Blog");
        }

        public async Task<IActionResult> BlogDelete(int id)
        {
            var response = await _blogService.Delete(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return BadRequest();

            return RedirectToAction("Blog");
        }

        public async Task<IActionResult> BlogChangeStatus(int id)
        {
            var response = await _blogService.Delete(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return BadRequest();

            return RedirectToAction("Blog");
        }

        #endregion

        #region Carousel

        public async Task<IActionResult> Carousel()
        {
            var response = await _carouselService.GetAll();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result);
        }

        public async Task<IActionResult> CarouselCreate()
        {
            return View(new CarouselCreateDto());
        }
        [HttpPost]
        public async Task<IActionResult> CarouselCreate(CarouselCreateDto dto)
        {
            var response = await _carouselService.Create(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Carousel");
        }

        public async Task<IActionResult> CarouselUpdate(int id)
        {
            var response = await _carouselService.GetById(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result);
        }
        [HttpPost]
        public async Task<IActionResult> CarouselUpdate(CarouselUpdateDto dto)
        {
            var response = await _carouselService.Update(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Carousel");
        }

        public async Task<IActionResult> CarouselDelete(int id)
        {
            var response = await _carouselService.Delete(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return BadRequest();

            return RedirectToAction("Carousel");
        }

        public async Task<IActionResult> CarouselChangeStatus(int id)
        {
            var response = await _carouselService.Delete(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return BadRequest();

            return RedirectToAction("Carousel");
        }

        #endregion

        #region Product

        public async Task<IActionResult> Product()
        {
            var response = await _productService.GetAll();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result);
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View(new ProductCreateDto());
        }
        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductCreateDto dto)
        {
            var response = await _productService.Create(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Product");
        }

        public async Task<IActionResult> ProductUpdate(int id)
        {
            var response = await _productService.GetById(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result);
        }
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductUpdateDto dto)
        {
            var response = await _productService.Update(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Product");
        }

        public async Task<IActionResult> ProductDelete(int id)
        {
            var response = await _productService.Delete(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return BadRequest();

            return RedirectToAction("Product");
        }

        public async Task<IActionResult> ProductChangeStatus(int id)
        {
            var response = await _productService.Delete(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return BadRequest();

            return RedirectToAction("Product");
        }

        #endregion

        #region AboutUs

        public async Task<IActionResult> AboutUs()
        {
            var response = await _aboutUsService.GetAll();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            var mappedResponse = response.Result.Adapt<List<AboutUsModel>>();
            return View(mappedResponse);
        }

        public async Task<IActionResult> AboutUsUpdate(int id)
        {
            var response = await _aboutUsService.GetById(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            var mappedResponse = response.Result.Adapt<AboutUsUpdateModel>();
            return View(mappedResponse);
        }
        [HttpPost]
        public async Task<IActionResult> AboutUsUpdate(AboutUsUpdateModel model)
        {
            var dto = model.Adapt<AboutUsUpdateDto>();
            var response = await _aboutUsService.Update(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("AboutUs");
        }

        #endregion

        #region Editor Upload


        [HttpPost]
        public async Task<IActionResult> UploadImage(List<IFormFile> files)
        {
            var filePath = "";
            
            foreach (var photo in Request.Form.Files)
            {
                var newName = Guid.NewGuid().ToString();
                var fileExtension = Path.GetExtension(photo.FileName);
                var serverMapPath = Path.Combine(_webHostEnvironment.WebRootPath, "EditorImage", newName + fileExtension);
                using (var stream = new FileStream(serverMapPath, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }
                filePath ="\\EditorImage\\" + newName + fileExtension;
            }
            return Json(new { url = filePath });
        }
        #endregion
    }
}
