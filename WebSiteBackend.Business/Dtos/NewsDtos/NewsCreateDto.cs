using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Business.Dtos.NewsDtos
{
    public class NewsCreateDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public LanguageEnum Language { get; set; }
    }
}
