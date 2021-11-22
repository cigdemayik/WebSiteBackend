using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Dtos.CategoryDtos;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Business.Dtos.NewsDtos
{
    public class NewsDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
