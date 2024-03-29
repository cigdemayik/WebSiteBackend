﻿using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Entities.Concrete
{
    public class Category :BaseEntity, ITable
    {
        public string Name { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<News> News { get; set; }
        public int Language { get; set; }
    }
}
