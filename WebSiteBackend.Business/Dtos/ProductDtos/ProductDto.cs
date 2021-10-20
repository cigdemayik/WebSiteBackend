using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Business.Dtos.ProductDtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public bool Active { get; set; }
        public string ImageUrl { get; set; }
    }
}
