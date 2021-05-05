using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;

namespace WebSiteBackend.Entities.Concrete
{
    public class Blog : BaseEntity, ITable
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        [JsonIgnore]
        public IFormFile Image { get; set; }
        public DateTime ReleaseTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
