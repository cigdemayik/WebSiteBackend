﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.AddressModels
{
    public class AddressCreateModel
    {
        public int Id { get; set; }
        [DisplayName("Dil")]
        public LanguageEnum Language { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "Lütfen Bir İçerik Giriniz.")]
        public string Content { get; set; }
    }
}