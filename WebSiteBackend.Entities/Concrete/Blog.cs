using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;

namespace WebSiteBackend.Entities.Concrete
{
    public class Blog : BaseEntity, ITable
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime ReleaseTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
