using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using WebSiteBackend.Entities.Abstracts.Interfaces;
using WebSiteBackend.Entities.Concrete.BaseModel;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Entities.Concrete
{
    public class Carousel : BasePublishEntity, ITable
    {
        public string Header { get; set; }
        public string ImageUrl { get; set; }
        public string Detail { get; set; }
        public LanguageEnum Language { get; set; }
    }
}
