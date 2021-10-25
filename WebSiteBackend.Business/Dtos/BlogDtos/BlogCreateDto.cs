using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Business.Dtos.CategoryDtos;

namespace WebSiteBackend.Business.Dtos.BlogDtos
{
    public class BlogCreateDto
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; } = 1;
        public int CategoryId { get; set; }
    }
}
