using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels
{
    public class CategoryUpdateModel
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        [DisplayName("İsim")]
        [Required(ErrorMessage = "Lütfen Bir İsim Giriniz.")]
        public string Name { get; set; }
        public DateTime UpdateTime { get; set; }
        [DisplayName("Dil")]
        [Required(ErrorMessage = "Lütfen Bir Dil Seçiniz.")]
        public int Language { get; set; }
    }
}
