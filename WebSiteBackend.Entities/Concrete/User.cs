using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;

namespace WebSiteBackend.Entities.Concrete
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Blog> Blogs { get; set; }

    }
}
