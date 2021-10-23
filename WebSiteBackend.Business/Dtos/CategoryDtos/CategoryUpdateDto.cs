﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Business.Dtos.CategoryDtos
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}