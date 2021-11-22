using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.AboutUsModels
{
    public class AboutUsUpdateModel
    {
        public int Id { get; set; }
        [DisplayName("Dil")]
        public int Language { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Content { get; set; }
        [DisplayName("Link")]
        public string Link { get; set; }
        public bool Active { get; set; }=true;
        public string ImageUrl { get; set; }
        [DisplayName("Resim")]
        public IFormFile Image { get; set; }
    }
}
