using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Entities.Concrete.BaseModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool Deleted { get; set; }
    }
}
