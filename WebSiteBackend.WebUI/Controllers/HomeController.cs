using Mapster;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.WebUI.Extensions;
using WebSiteBackend.WebUI.Models;

namespace WebSiteBackend.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarouselService _carouselService;
        private readonly IBlogService _blogService;
        private readonly IAboutUsService _aboutUsService;
        private readonly IAddressService _addressService;
        private readonly IProductService _productService;

        public HomeController(ICarouselService carouselService, IBlogService blogService, IAboutUsService aboutUsService, IProductService productService, IAddressService addressService)
        {
            _carouselService = carouselService ?? throw new ArgumentNullException(nameof(carouselService));
            _blogService = blogService ?? throw new ArgumentNullException(nameof(blogService));
            _aboutUsService = aboutUsService ?? throw new ArgumentNullException(nameof(aboutUsService));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _addressService = addressService ?? throw new ArgumentNullException(nameof(addressService));
        }
        public async Task<IActionResult> IndexAsync()
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

        

    }
}
