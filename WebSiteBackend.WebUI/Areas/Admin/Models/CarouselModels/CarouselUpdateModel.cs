﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.CarouselModels
{
    public class CarouselUpdateModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string Detail { get; set; }
        public DateTime PublishStartDate { get; set; }
        public DateTime PublishEndDate { get; set; }
        public bool Active { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
