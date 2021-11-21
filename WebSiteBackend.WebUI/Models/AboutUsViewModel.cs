using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.AboutUsDtos;
using WebSiteBackend.Business.Dtos.ProductDtos;

namespace WebSiteBackend.WebUI.Models
{
    public class AboutUsViewModel
    {
        public AboutUsDto AboutUs { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
