using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.NewsModels
{
    public class NewsUpdateModel
    {
        public int Id { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [DisplayName("Resim")]
        [Required(ErrorMessage = "Lütfen Bir Resim Seçiniz.")]
        public IFormFile Image { get; set; }
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "Lütfen Bir Kategori Seçiniz.")]
        public int CategoryId { get; set; }
    }
}
