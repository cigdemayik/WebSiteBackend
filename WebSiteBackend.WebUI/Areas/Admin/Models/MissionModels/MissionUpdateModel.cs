using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.MissionModels
{
    public class MissionUpdateModel
    {
        public int Id { get; set; }
        [DisplayName("Dil")]
        [Required(ErrorMessage = "Lütfen Bir Dil Seçiniz.")]
        public int Language { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Content { get; set; }
    }
}
