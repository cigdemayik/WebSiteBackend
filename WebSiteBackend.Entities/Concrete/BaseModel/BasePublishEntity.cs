using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Entities.Concrete.BaseModel
{
    public class BasePublishEntity : BaseEntity
    {
        public DateTime PublishStartDate { get; set; }
        public DateTime PublishEndDate { get; set; }
    }
}
