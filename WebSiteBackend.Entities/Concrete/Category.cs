using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;

namespace WebSiteBackend.Entities.Concrete
{
    public class Category :BaseEntity, ITable
    {
        public string Name { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
