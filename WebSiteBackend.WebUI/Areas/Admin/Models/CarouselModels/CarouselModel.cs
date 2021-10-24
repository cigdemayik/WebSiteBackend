using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels
{
    public class CarouselModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        public string Detail { get; set; }
        public DateTime PublishStartDate { get; set; }
        public DateTime PublishEndDate { get; set; }
        public bool Active { get; set; }
        public LanguageEnum Language { get; set; }
    }
}
