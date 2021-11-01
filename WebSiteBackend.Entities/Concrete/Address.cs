using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete.BaseModel;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Entities.Concrete
{
    public class Address:BaseEntity
    {
        public string Content { get; set; }
        public LanguageEnum Language { get; set; }
    }
}
