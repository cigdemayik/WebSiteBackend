using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Business.Dtos.MissionDtos;
using WebSiteBackend.Business.Dtos.VisionDtos;

namespace WebSiteBackend.WebUI.Models
{
    public class VisionMissionViewModel
    {
        public VisionDto Vision { get; set; }
        public MissionDto Mission { get; set; }
    }
}
