using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Entities.Concrete
{
    public class User : BaseEntity, ITable
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public LanguageEnum Language { get; set; }

    }
}
