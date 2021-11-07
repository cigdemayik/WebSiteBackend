using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels
{
    public class BlogUpdateModel
    {
        public int Id { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Lütfen Bir Başlık Giriniz.")]
        public string Header { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [DisplayName("Resim")]
        [Required(ErrorMessage = "Lütfen Bir Resim Seçiniz.")]
        public IFormFile Image { get; set; }
        public int UserId { get; set; } = 1;
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "Lütfen Bir Kategori Seçiniz.")]
        public int CategoryId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
