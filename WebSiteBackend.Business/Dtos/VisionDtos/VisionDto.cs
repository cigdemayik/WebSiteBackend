using System;
using System.Collections.Generic;
using System.Text;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.Business.Dtos.VissionMissionDtos
{
    public class VisionDto
    {
        public int Id { get; set; }
        public LanguageEnum Language { get; set; }
        public string Content { get; set; }
    }
}
