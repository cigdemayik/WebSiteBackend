﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteBackend.Helpers.Enums;

namespace WebSiteBackend.WebUI.Areas.Admin.Models.MissionModels
{
    public class MissionModel
    {
        public int Id { get; set; }
        public LanguageEnum Language { get; set; }
        public string Content { get; set; }
    }
}
