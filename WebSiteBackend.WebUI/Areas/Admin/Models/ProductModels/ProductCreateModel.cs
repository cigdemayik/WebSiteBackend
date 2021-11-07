using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.ProductModels
{
    public class ProductCreateModel
    {
        [DisplayName("isim")]
        [Required(ErrorMessage = "Lütfen Bir İsim Giriniz.")]
        public string Name { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [DisplayName("Resim")]
        [Required(ErrorMessage = "Lütfen Bir Resim Seçiniz.")]
        public IFormFile Image { get; set; }
    }
}
