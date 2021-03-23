using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;

namespace WebSiteBackend.Entities.Concrete
{
    public class Carousel : BaseEntity, ITable
    {
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        public string Detail { get; set; }
    }
}
