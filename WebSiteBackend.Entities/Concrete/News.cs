using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete.BaseModel;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Entities.Concrete
{
    public class News: BaseEntity
    {
        public LanguageEnum Language { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
