using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Concrete.BaseModel;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Entities.Concrete
{
    public class ExceptionLog : BaseEntity
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string InnerMessage { get; set; }
        public string Method { get; set; }
        public int Layer { get; set; }
    }
}
