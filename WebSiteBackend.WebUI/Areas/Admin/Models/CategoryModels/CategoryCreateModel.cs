using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.CategoryModels
{
    public class CategoryCreateModel
    {
        public string Name { get; set; }
        public LanguageEnum Language { get; set; }
    }
}
