using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.WebUI.Extensions;
using WebSiteBackend.WebUI.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Diagnostics;

namespace WebSiteBackend.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarouselService _carouselService;
        private readonly IBlogService _blogService;
        private readonly IAboutUsService _aboutUsService;
        private readonly IAddressService _addressService;
        private readonly IProductService _productService;
        private readonly IVisionService _visionService;
        private readonly IMissionService _missionService;
        private readonly ILocalizationResourceService _localization;

        public HomeController
            (ICarouselService carouselService, IBlogService blogService, 
            IAboutUsService aboutUsService, IProductService productService, 
            IAddressService addressService, IMissionService missionService, 
            IVisionService visionService)
        {
            _carouselService = carouselService ?? throw new ArgumentNullException(nameof(carouselService));
            _blogService = blogService ?? throw new ArgumentNullException(nameof(blogService));
            _aboutUsService = aboutUsService ?? throw new ArgumentNullException(nameof(aboutUsService));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _addressService = addressService ?? throw new ArgumentNullException(nameof(addressService));
            _missionService = missionService ?? throw new ArgumentNullException(nameof(missionService));
            _visionService = visionService ?? throw new ArgumentNullException(nameof(visionService));
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new IndexViewModel();
            var activeCulture = this.GetActiveCulture();


            var carouselResult = await _carouselService.GetAllByLanguage(activeCulture);
            if (carouselResult.IsSuccessful)
                model.Carousels = carouselResult.Result;


            var blogResult = await _blogService.GetByLanguage(activeCulture);
            if (blogResult.IsSuccessful)
                model.Blog = blogResult.Result;

            var aboutUsResult = await _aboutUsService.GetByLanguage(activeCulture);
            if (aboutUsResult.IsSuccessful)
                model.AboutUs = aboutUsResult.Result;

            var productResult = await _productService.GetAllByLanguage(activeCulture);
            if (productResult.IsSuccessful)
                model.Products = productResult.Result;

            var addressResult = await _addressService.GetByLanguage(activeCulture);
            if (addressResult.IsSuccessful)
                model.Address = addressResult.Result;

            return View(model);
        }

        public async Task<IActionResult> About()
        {
            var model = new AboutUsViewModel();
            var activeCulture = this.GetActiveCulture();
            var aboutUsResult = await _aboutUsService.GetByLanguage(activeCulture);
            var productResult = await _productService.GetAllByLanguage(activeCulture);
            if (aboutUsResult.IsSuccessful)
                model.AboutUs = aboutUsResult.Result;
            if (productResult.IsSuccessful)
                model.Products = productResult.Result;
            return View(model);
        }
        //TO DO: Pagination Eklenecek.
        public async Task<IActionResult> Blog()
        {
            var model = new BlogViewModel();
            var activeCulture = this.GetActiveCulture();
            var blogResult = await _blogService.GetAllByLanguage(activeCulture);
            if (blogResult.IsSuccessful)
                model.Blogs = blogResult.Result;
            return View(model);
        }

        public async Task<IActionResult> VisionMission()
        {
            var model = new VisionMissionViewModel();
            var activeCulture = this.GetActiveCulture();

            var visionResult = await _visionService.GetByLanguage(activeCulture);
            if (visionResult.IsSuccessful)
                model.Vision = visionResult.Result;

            var missionResult = await _missionService.GetByLanguage(activeCulture);
            if (missionResult.IsSuccessful)
                model.Mission = missionResult.Result;


            return View(model);
        }
        [HttpGet]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddDays(30)
            });
            returnUrl = "Index";

            return RedirectToAction(returnUrl);
        }

        public async Task<IActionResult> NotFound(int code)
        {
            ViewBag.Code = code;
            return View();
        }
        [Route("/Error")]
        public async Task<IActionResult> Error()
        {
        //    var errorInfo=HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            return View();
        }
    }
}
