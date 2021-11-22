using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Abstracts.Interfaces;
using WebSiteBackend.WebUI.Models;

namespace WebSiteBackend.WebUI.Components
{
    public class Footer : ViewComponent
    {
        private readonly IAddressService _addressService;

        public Footer(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int activeCulture = 2;
            var culture = HttpContext.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>();
            if (culture.RequestCulture.Culture.Name == "tr")
                activeCulture = 1;
            var model = new AddressViewModel();
            var result =await _addressService.GetByLanguage(activeCulture);
            if (result.IsSuccessful)
                model.Address = result.Result;
            return View("Footer",model);
        }
    }
}
