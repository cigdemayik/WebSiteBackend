using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.Business.Dtos.AboutUsDtos;
using WebSiteBackend.Business.Dtos.AddressDtos;
using WebSiteBackend.Business.Dtos.BlogDtos;
using WebSiteBackend.Business.Dtos.CarouselDtos;
using WebSiteBackend.Business.Dtos.CategoryDtos;
using WebSiteBackend.Business.Dtos.MissionDtos;
using WebSiteBackend.Business.Dtos.ProductDtos;
using WebSiteBackend.Business.Dtos.VissionMissionDtos;
using WebSiteBackend.WebUI.Areas.Admin.Models.AboutUsModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.AddressModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.MissionModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.ProductModels;
using WebSiteBackend.WebUI.Areas.Admin.Models.VisionModels;
using WebSiteBackend.WebUI.Extensions;

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
        private readonly IVisionService _visionService;
        private readonly IAddressService _addressService;
        private readonly IMissionService _missionService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ICategoryService categoryService, IProductService productService, ICarouselService carouselService, IBlogService blogService, IAboutUsService aboutUsService, IMissionService missionService, IAddressService addressService ,IVisionService visionService ,IWebHostEnvironment webHostEnvironment)
        {
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _carouselService = carouselService ?? throw new ArgumentNullException(nameof(carouselService));
            _blogService = blogService ?? throw new ArgumentNullException(nameof(blogService));
            _aboutUsService = aboutUsService ?? throw new ArgumentNullException(nameof(aboutUsService));
            _visionService = visionService ?? throw new ArgumentException(nameof(visionService));
            _missionService = missionService ?? throw new ArgumentException(nameof(missionService));
            _addressService = addressService ?? throw new ArgumentException(nameof(addressService));
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
            return View(response.Result.Adapt<CategoryUpdateModel>());
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
            var categories = await _categoryService.GetAll();
            var data = new List<SelectListItem>();
            foreach (var item in categories.Result)
            {
                data.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.Categories = data;
            return View(new BlogCreateModel());
        }
        [HttpPost]
        public async Task<IActionResult> BlogCreate(BlogCreateModel model)
        {

            var savePath = "\\uploads\\blog";
            var filePath = _webHostEnvironment.WebRootPath + savePath;

            model.ImageUrl = await this.UploadFileAsync(model.Image, filePath, savePath);
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
            var categories = await _categoryService.GetAll();
            var data = new List<SelectListItem>();
            foreach (var item in categories.Result)
            {
                data.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.Categories = data;
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
            var savePath = "\\uploads\\blog";
            var filePath = _webHostEnvironment.WebRootPath + savePath;
            model.ImageUrl = await this.UploadFileAsync(model.Image, filePath, savePath);
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
            var savePath = "\\uploads\\carousel";
            var filePath = _webHostEnvironment.WebRootPath + savePath;
            model.ImageUrl = await this.UploadFileAsync(model.Image, filePath, savePath);
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
            var savePath = "\\uploads\\carousel";
            var filePath = _webHostEnvironment.WebRootPath + savePath;
            model.ImageUrl = await this.UploadFileAsync(model.Image, filePath, savePath);
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
            var savePath = "\\uploads\\product";
            var filePath = _webHostEnvironment.WebRootPath + savePath;
            model.ImageUrl = await this.UploadFileAsync(model.Image, filePath, savePath);

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
            var savePath = "\\uploads\\product";
            var filePath = _webHostEnvironment.WebRootPath + savePath;
            model.ImageUrl = await this.UploadFileAsync(model.Image, filePath, savePath);

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
                filePath = "\\EditorImage\\" + newName + fileExtension;
            }
            return Json(new { url = filePath });
        }
        #endregion

        #region Vission
        public async Task<IActionResult> Vision()
        {
            var response = await _visionService.GetAll();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }

            return View(response.Result.Adapt<List<VisionModel>>());
        }

        public async Task<IActionResult> VisionUpdate(int id)
        {
            var response = await _visionService.GetById(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result.Adapt<VisionUpdateModel>());
        }
        [HttpPost]
        public async Task<IActionResult> VisionUpdate(VisionUpdateDto dto)
        {
            var response = await _visionService.Update(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Vision");
        }
        #endregion

        #region Address
        public async Task<IActionResult> Address()
        {
            var response = await _addressService.GetAll();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }

            return View(response.Result.Adapt<List<AddressModel>>());
        }

        public async Task<IActionResult> AddressUpdate(int id)
        {
            var response = await _addressService.GetById(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result.Adapt<AddressUpdateModel>());
        }
        [HttpPost]
        public async Task<IActionResult> AddressUpdate(AddressUpdateDto dto)
        {
            var response = await _addressService.Update(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Address");
        }
        #endregion

        #region Mission
        public async Task<IActionResult> Mission()
        {
            var response = await _missionService.GetAll();
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }

            return View(response.Result.Adapt<List<MissionModel>>());
        }

        public async Task<IActionResult> MissionUpdate(int id)
        {
            var response = await _missionService.GetById(id);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return View(response.Result.Adapt<MissionUpdateModel>());
        }
        [HttpPost]
        public async Task<IActionResult> MissionUpdate(MissionUpdateDto dto)
        {
            var response = await _missionService.Update(dto);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return BadRequest();
            }
            return RedirectToAction("Mission");
        }
        #endregion
    }
}

//var savePath = "\\uploads\\article";
//var filePath = _webHostEnvironment.WebRootPath + savePath;

//mappedModel.ImagePath = await this.UploadFileAsync(model.File, filePath, savePath);