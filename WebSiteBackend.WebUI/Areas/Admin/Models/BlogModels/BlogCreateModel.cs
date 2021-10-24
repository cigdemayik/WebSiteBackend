﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.BlogModels
{
    public class BlogCreateModel
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; } = 1;
        public int CategoryId { get; set; }
    }
}