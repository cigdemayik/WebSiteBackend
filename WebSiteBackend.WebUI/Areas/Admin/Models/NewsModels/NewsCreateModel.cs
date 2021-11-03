using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.NewsModels
{
    public class NewsCreateModel
    {
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public int CategoryId { get; set; }
    }
}
