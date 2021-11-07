using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.AddressModels
{
    public class AddressUpdateModel
    {
        public int Id { get; set; }
        [DisplayName("Dil")]
        public int Language { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Content { get; set; }
    }
}
