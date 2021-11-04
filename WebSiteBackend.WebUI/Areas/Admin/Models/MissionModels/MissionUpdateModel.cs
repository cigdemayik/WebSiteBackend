using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.MissionModels
{
    public class MissionUpdateModel
    {
        public int Id { get; set; }
        public int Language { get; set; }
        public string Content { get; set; }
    }
}
