using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;

namespace WebSiteBackend.Entities.Concrete
{
    public class Product : BaseEntity, ITable
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
