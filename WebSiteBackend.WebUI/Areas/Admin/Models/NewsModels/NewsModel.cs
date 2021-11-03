﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Helpers.Enums;
using WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.NewsModels
{
    public class NewsModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public LanguageEnum Language { get; set; }
    }
}
