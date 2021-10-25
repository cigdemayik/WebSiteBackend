using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebSiteBackend.Business.Dtos.CarouselDtos
{
    public class CarouselCreateDto
    {
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        public string Detail { get; set; }
        public int Language { get; set; }
    }
}
