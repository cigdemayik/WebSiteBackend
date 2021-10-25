using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels
{
    public class CarouselCreateModel
    {
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public string Detail { get; set; }
        public int Language { get; set; }
    }
}
