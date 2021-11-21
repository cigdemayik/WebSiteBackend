using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Business.Dtos.AboutUsDtos
{
    public class AboutUsDto
    {
        public int Id { get; set; }
        public LanguageEnum Language { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
    }
}
