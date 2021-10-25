using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.ProductModels
{
    public class ProductUpdateModel
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public DateTime UpdateTime { get; set; }
        public IFormFile Image { get; set; }
    }
}
