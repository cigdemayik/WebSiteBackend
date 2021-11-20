using System.Collections.Generic;
using WebSiteBackend.Business.Dtos.AboutUsDtos;
using WebSiteBackend.Business.Dtos.AddressDtos;
using WebSiteBackend.Business.Dtos.BlogDtos;
using WebSiteBackend.Business.Dtos.CarouselDtos;
using WebSiteBackend.Business.Dtos.ProductDtos;

namespace WebSiteBackend.WebUI.Models
{
    public class IndexViewModel
    {
        public List<CarouselDto> Carousels { get; set; }
        public AboutUsDto AboutUs { get; set; }
        public BlogDto Blog { get; set; }
        public List<ProductDto> Products  { get; set; }
        public AddressDto Address { get; set; }
    }
}
