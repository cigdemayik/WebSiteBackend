using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.AboutUsDtos;
using WebSiteBackend.Business.Dtos.BlogDtos;
using WebSiteBackend.Business.Dtos.CarouselDtos;
using WebSiteBackend.Business.Dtos.CategoryDtos;
using WebSiteBackend.Business.Dtos.ProductDtos;
using WebSiteBackend.WebUI.Areas.Admin.Models.AboutUsModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.ProductModels;

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
            _webHostEnvironment = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
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
            return View(response.Result.Adapt<List<CategoryModel>>());
        }

        public async Task<IActionResult> CategoryCreate()
        {
            return View(new CategoryCreateModel());
        }
        [HttpPost]
        public async Task<IActionResult> CategoryCreate(CategoryCreateModel model)
        {
            var mappeddata = model.Adapt<CategoryCreateDto>();
            var response = await _categoryService.Create(mappeddata);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
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
        public async Task<IActionResult> CategoryUpdate(CategoryUpdateModel model)
        {
            var mappedData = model.Adapt<CategoryUpdateDto>();
            var response = await _categoryService.Update(mappedData);
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
           return View(response.Result.Adapt<List<BlogModel>>());
        }

        public async Task<IActionResult> BlogCreate()
        {
            return View(new BlogCreateModel());
        }
        [HttpPost]
        public async Task<IActionResult> BlogCreate(BlogCreateModel model)
        {
            var mappedData = model.Adapt<BlogCreateDto>();
            var response = await _blogService.Create(mappedData);
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
            return View(response.Result.Adapt<BlogUpdateModel>());
        }
        [HttpPost]
        public async Task<IActionResult> BlogUpdate(BlogUpdateModel model)
        {
            var mappedData = model.Adapt<BlogUpdateDto>();
            var response = await _blogService.Update(mappedData);
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
            return View(response.Result.Adapt<List<CarouselModel>>());
        }

        public async Task<IActionResult> CarouselCreate()
        {
            return View(new CarouselCreateModel());
        }
        [HttpPost]
        public async Task<IActionResult> CarouselCreate(CarouselCreateModel model)
        {
            var mappedData = model.Adapt<CarouselCreateDto>();
            var response = await _carouselService.Create(mappedData);
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
            return View(response.Result.Adapt<CarouselUpdateModel>());
        }
        [HttpPost]
        public async Task<IActionResult> CarouselUpdate(CarouselUpdateModel model)
        {
            var mappedData = model.Adapt<CarouselUpdateDto>();
            var response = await _carouselService.Update(mappedData);
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
            return View(response.Result.Adapt<List<ProductModel>>());
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View(new ProductCreateModel());
        }
        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductCreateModel model)
        {
            var mappedData = model.Adapt<ProductCreateDto>();
            var response = await _productService.Create(mappedData);
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
            return View(response.Result.Adapt<ProductUpdateModel>());
        }
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductUpdateModel model)
        {
            var mappedData = model.Adapt<ProductUpdateDto>();
            var response = await _productService.Update(mappedData);
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

            return View(response.Result.Adapt<List<AboutUsModel>>());
        }

        public async Task<IActionResult> AboutUsUpdate(int id)
        {
            var response = await _aboutUsService.GetById(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result.Adapt<AboutUsUpdateModel>());
        }
        [HttpPost]
        public async Task<IActionResult> AboutUsUpdate(AboutUsUpdateDto dto)
        {
            var response = await _aboutUsService.Update(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("AboutUs");
        }

        #endregion
    }
}

//var savePath = "\\uploads\\article";
//var filePath = _webHostEnvironment.WebRootPath + savePath;

//mappedModel.ImagePath = await this.UploadFileAsync(model.File, filePath, savePath);