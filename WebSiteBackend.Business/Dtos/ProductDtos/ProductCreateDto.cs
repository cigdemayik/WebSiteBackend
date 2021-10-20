using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Business.Dtos.ProductDtos
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
