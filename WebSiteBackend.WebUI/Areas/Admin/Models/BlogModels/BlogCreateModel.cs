using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels
{
    public class BlogCreateModel
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage ="Lütfen Bir Başlık Giriniz.")]
        public string Header { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [DisplayName("Resim")]
        [NotMapped]
        [Required(ErrorMessage ="Bir Resim Seçmek Zorundasınız.")]
        public IFormFile Image { get; set; }
        public int UserId { get; set; } = 1;
        [DisplayName("Kategori")]
        [Required(ErrorMessage ="Bir Kategori Seçmek Zorundasınız.")]
        public int CategoryId { get; set; }

    }
}
