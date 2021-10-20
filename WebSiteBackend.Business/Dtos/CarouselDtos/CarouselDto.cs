using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebSiteBackend.Business.Dtos.CarouselDtos
{
    public class CarouselDto
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        public string Detail { get; set; }
        public DateTime PublishStartDate { get; set; }
        public DateTime PublishEndDate { get; set; }
        public bool Active { get; set; }
    }
}
