using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels
{
    public class CategoryCreateModel
    {
        [DisplayName("İsim")]
        [Required(ErrorMessage = "Lütfen Bir İsim Giriniz.")]
        public string Name { get; set; }
        [DisplayName("Dil")]
        [Required(ErrorMessage = "Lütfen Bir Dil Seçiniz.")]
        public LanguageEnum Language { get; set; }
    }
}
