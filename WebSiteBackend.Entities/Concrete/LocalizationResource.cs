using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete.BaseModel;

namespace WebSiteBackend.Entities.Concrete
{
    public class LocalizationResource : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public int Language { get; set; }

    }
}
