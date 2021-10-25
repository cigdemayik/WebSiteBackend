using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.ProductModels
{
    public class ProductCreateModel
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
