using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels
{
    public class CarouselUpdateModel
    {
        public int Id { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Lütfen Bir Başlık Giriniz.")]
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        [DisplayName("Resim")]
        [NotMapped]
        [Required(ErrorMessage = "Lütfen Bir Resim Seçiniz")]
        public IFormFile Image { get; set; }
        [DisplayName("Detay")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Detail { get; set; }
        public DateTime PublishStartDate { get; set; }
        public DateTime PublishEndDate { get; set; }
        public bool Active { get; set; }
    }
}
