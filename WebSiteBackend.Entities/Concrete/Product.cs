using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Entities.Concrete
{
    public class Product : BaseEntity, ITable
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public LanguageEnum Language { get; set; }
    }
}
