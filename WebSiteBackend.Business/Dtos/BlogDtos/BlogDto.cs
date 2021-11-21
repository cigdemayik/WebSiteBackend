using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Dtos.CategoryDtos;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Business.Dtos.BlogDtos
{
    public class BlogDto
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; } = 1;
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public int Language { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
