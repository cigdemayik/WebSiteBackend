using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using WebSiteBackend.Business.Dtos.CategoryDtos;

namespace WebSiteBackend.Business.Dtos.BlogDtos
{
    public class BlogUpdateDto
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; } = 1;
        public int CategoryId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Language { get; set; }
    }
}
