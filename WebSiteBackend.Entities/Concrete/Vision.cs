using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete.BaseModel;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Entities.Concrete
{
    public class Vision:BaseEntity
    {
        public string Content { get; set; }
        public int Language { get; set; }
    }
}
