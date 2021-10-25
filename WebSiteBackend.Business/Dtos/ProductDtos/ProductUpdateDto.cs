using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Business.Dtos.ProductDtos
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
